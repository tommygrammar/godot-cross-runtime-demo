"""
Godot API bridge generator.

Usage:
    python3 generate_api.py api.json <output_dir>

Produces:
    <output_dir>/cpp/headers/bridge_api.h
    <output_dir>/cpp/headers/bridge_helpers.h 
    <output_dir>/command_dispatcher.cpp
    <output_dir>/cpp/<ClassName>.cpp
    <output_dir>/cs/Commands.cs
    <output_dir>/cs/GodotApi/GodotObject.cs
    <output_dir>/cs/GodotApi/<ClassName>.cs

Key invariant:
    Every object handle passed between C# and C++ is a real Godot ObjectID.
    Raw pointers are never written back as handles.
"""

from __future__ import annotations

import json
import re
import shutil
import sys
from collections import defaultdict, OrderedDict
from pathlib import Path
from typing import Any, Dict, Iterable, List, Optional, Sequence, Tuple



# ----------------------------
# Emitters
# ----------------------------






 


if __name__ == "__main__":
    if len(sys.argv) != 3:
        print("Usage: generate_api.py <api.json> <output_dir>")
        sys.exit(1)
    main(sys.argv[1], sys.argv[2])
