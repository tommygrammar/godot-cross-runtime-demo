from typing import List, Dict
from collections import OrderedDict, defaultdict
import sys
import json
from pathlib import Path


from utilities import load_entries, normalize_args, sanitize_identifier, unique_identifier, method_signature, make_command_name, order_classes, cpp_class_file_name, cs_class_file_name, force_return_type
from cpp_generators import generate_cpp_helpers_copy, generate_command_dispatcher, generate_cpp_class_file, generate_bridge_api_header
from cs_generators import generate_commands_cs, generate_godot_object_cs, generate_cs_class_file
from metadata import return_types

def main(json_path, folder_path):
    entries = load_entries(json_path)

    class_methods: Dict[str, List[tuple]] = defaultdict(list)
    class_parent: Dict[str, str] = {}
    seen_methods = set()
    command_defs: List[dict] = []
    

    for entry in entries:
        if not isinstance(entry, dict):
            continue
        
        #it gets all the class information, there are some being intentionally skipped
        class_ = entry.get("class")
        if class_[0:6] !=  "Editor" :
            if class_[0:12] != "VisualShader":
                if class_[0:4] != "GLTF":
                    if class_[0:3] != "FBX":
                        if class_[0:16] != "ResourceImporter":
                    
                    
                            name = entry.get("name")
                            arguments = entry.get("args", [])
                            ret_type = entry.get("return_type")
                    
                            if not class_ or not name or ret_type not in return_types:
                                continue
                    
                            class_ = str(class_)
                            name = str(name)
                            parent = entry.get("parent", "")
                            class_parent[class_] = str(parent) if parent else ""
                    
                            args_norm = normalize_args(arguments)
                            if args_norm is None:
                                continue
                    
                            ret_type = force_return_type(class_, name, int(ret_type))
                            sig = method_signature(class_, name, args_norm, ret_type)
                            if sig in seen_methods:
                                continue
                            seen_methods.add(sig)
                    
                            const_name = make_command_name(class_, name, args_norm, ret_type)
                            cmd_id = len(command_defs) + 2  # reserve 0 and 1
                    
                            
                    
                            command_defs.append(
                                {
                                    "const_name": const_name,
                                    "cmd_id": cmd_id,
                                    "class": class_,
                                    "name": name,
                                    "args": args_norm,
                                    "ret_type": ret_type,
                                }
                            )
                            class_methods[class_].append((name, args_norm, ret_type, const_name, cmd_id))
                        else:
                            continue
                    else:
                        continue
                else:
                    continue
            else:
                continue
        else:
            continue

    

    out = Path(folder_path)
    cpp_out = out / "cpp"
    cs_out = out / "cs"
    cpp_out.mkdir(parents=True, exist_ok=True)
    cs_api_out = cs_out / "GodotApi"
    cs_api_out.mkdir(parents=True, exist_ok=True)
    (cpp_out / "headers").mkdir(parents=True, exist_ok=True)

    script_dir = Path(__file__).resolve().parent if "__file__" in globals() else Path.cwd()
    generate_cpp_helpers_copy(out, script_dir)

    ordered_classes = order_classes(class_methods, class_parent)

    cls_data = OrderedDict()
    for cls in ordered_classes:
        cls_data[cls] = (class_parent.get(cls, ""), class_methods[cls])

    cpp_class_map: Dict[str, str] = {}
    cs_class_map: Dict[str, str] = {}
    used_cpp_class_names = set()
    used_cs_class_names = set()
    for cls in cls_data.keys():
        cpp_class_map[cls] = cpp_class_file_name(cls, used_cpp_class_names)
        cs_class_map[cls] = cs_class_file_name(cls, used_cs_class_names)

    generate_bridge_api_header(out, command_defs)
    generate_commands_cs(out, command_defs)
    generate_godot_object_cs(out)

    for cls, (_, methods) in cls_data.items():
        generate_cpp_class_file(out, cpp_class_map[cls], cls, methods)

    for cls, (parent_name, methods) in cls_data.items():
        cs_cls = cs_class_map[cls]
        cs_base = cs_class_map.get(parent_name, "GodotObject") if parent_name and parent_name in cs_class_map else "GodotObject"
        generate_cs_class_file(out, cs_class_map[cls], cs_cls, cs_base, methods)

    generate_command_dispatcher(out, ordered_classes, cpp_class_map, command_defs)

    print(f"Generated files in {out}.")
    print(f"C++ output: {cpp_out}")
    print(f"C# output: {cs_out}")
    
    print(f"Total commands: {len(command_defs)}")
   
# run the generator
if len(sys.argv) != 3:
    print("Usage: generate_api.py <api.json> <output_dir>")
    sys.exit(1)
    
main(sys.argv[1], sys.argv[2])