using System;

namespace GodotWeb
{
    public class NavigationServer3D : GodotObject
    {
        public NavigationServer3D(ulong id) : base(id) { }

        public object get_maps()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_get_maps__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public ulong map_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void map_set_active(ulong map, bool active)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, active ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_set_active__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool map_is_active(ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_is_active__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void map_set_up(ulong map, Vector3 up)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, up);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_set_up__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 map_get_up(ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_up__23__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void map_set_cell_size(ulong map, double cell_size)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, cell_size);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_set_cell_size__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double map_get_cell_size(ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_cell_size__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void map_set_cell_height(ulong map, double cell_height)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, cell_height);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_set_cell_height__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double map_get_cell_height(ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_cell_height__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void map_set_merge_rasterizer_cell_scale(ulong map, double scale)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, scale);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_set_merge_rasterizer_cell_scale__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double map_get_merge_rasterizer_cell_scale(ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_merge_rasterizer_cell_scale__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void map_set_use_edge_connections(ulong map, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_set_use_edge_connections__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool map_get_use_edge_connections(ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_use_edge_connections__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void map_set_edge_connection_margin(ulong map, double margin)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, margin);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_set_edge_connection_margin__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double map_get_edge_connection_margin(ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_edge_connection_margin__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void map_set_link_connection_radius(ulong map, double radius)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, radius);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_set_link_connection_radius__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double map_get_link_connection_radius(ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_link_connection_radius__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public Vector3[] map_get_path(ulong map, Vector3 origin, Vector3 destination, bool optimize, long navigation_layers)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, origin);
            Helpers.WriteVector3(Commands.CMD_DATA + 28, destination);
            Helpers.WriteInt32(Commands.CMD_DATA + 40, optimize ? 1 : 0);
            Helpers.WriteInt64(Commands.CMD_DATA + 44, navigation_layers);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_path__23__9__9__1__2__r36);
            Helpers.WaitForCompletion();
            Vector3[] result = Helpers.ReadPackedVector3Array(Commands.CMD_DATA);
            return result;
        }

        public Vector3 map_get_closest_point_to_segment(ulong map, Vector3 start, Vector3 end, bool use_collision)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, start);
            Helpers.WriteVector3(Commands.CMD_DATA + 28, end);
            Helpers.WriteInt32(Commands.CMD_DATA + 40, use_collision ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_closest_point_to_segment__23__9__9__1__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public Vector3 map_get_closest_point(ulong map, Vector3 to_point)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, to_point);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_closest_point__23__9__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public Vector3 map_get_closest_point_normal(ulong map, Vector3 to_point)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, to_point);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_closest_point_normal__23__9__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public ulong map_get_closest_point_owner(ulong map, Vector3 to_point)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, to_point);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_closest_point_owner__23__9__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public object map_get_links(ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_links__23__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object map_get_regions(ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_regions__23__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object map_get_agents(ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_agents__23__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object map_get_obstacles(ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_obstacles__23__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void map_force_update(ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_force_update__23__r0);
            Helpers.WaitForCompletion();
        }

        public long map_get_iteration_id(ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_iteration_id__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void map_set_use_async_iterations(ulong map, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_set_use_async_iterations__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool map_get_use_async_iterations(ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_use_async_iterations__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public Vector3 map_get_random_point(ulong map, long navigation_layers, bool uniformly)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, map);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, navigation_layers);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, uniformly ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_map_get_random_point__23__2__1__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void query_path(ulong parameters, ulong arg_result, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, parameters);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, arg_result);
            Helpers.WriteCallable(Commands.CMD_DATA + 24, callback);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_query_path__24__24__25__r0);
            Helpers.WaitForCompletion();
        }

        public ulong region_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public long region_get_iteration_id(ulong region)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_get_iteration_id__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void region_set_use_async_iterations(ulong region, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_set_use_async_iterations__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool region_get_use_async_iterations(ulong region)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_get_use_async_iterations__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void region_set_enabled(ulong region, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_set_enabled__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool region_get_enabled(ulong region)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_get_enabled__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void region_set_use_edge_connections(ulong region, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_set_use_edge_connections__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool region_get_use_edge_connections(ulong region)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_get_use_edge_connections__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void region_set_enter_cost(ulong region, double enter_cost)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, enter_cost);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_set_enter_cost__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double region_get_enter_cost(ulong region)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_get_enter_cost__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void region_set_travel_cost(ulong region, double travel_cost)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, travel_cost);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_set_travel_cost__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double region_get_travel_cost(ulong region)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_get_travel_cost__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void region_set_owner_id(ulong region, long owner_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, owner_id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_set_owner_id__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long region_get_owner_id(ulong region)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_get_owner_id__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool region_owns_point(ulong region, Vector3 point)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, point);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_owns_point__23__9__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void region_set_map(ulong region, ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.WriteRID(Commands.CMD_DATA + 16, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_set_map__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong region_get_map(ulong region)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_get_map__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void region_set_navigation_layers(ulong region, long navigation_layers)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, navigation_layers);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_set_navigation_layers__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long region_get_navigation_layers(ulong region)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_get_navigation_layers__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void region_set_transform(ulong region, Transform3D transform)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.WriteTransform3D(Commands.CMD_DATA + 16, transform);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_set_transform__23__18__r0);
            Helpers.WaitForCompletion();
        }

        public Transform3D region_get_transform(ulong region)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_get_transform__23__r18);
            Helpers.WaitForCompletion();
            Transform3D result = Helpers.ReadTransform3D(Commands.CMD_DATA);
            return result;
        }

        public void region_set_navigation_mesh(ulong region, ulong navigation_mesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, navigation_mesh);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_set_navigation_mesh__23__24__r0);
            Helpers.WaitForCompletion();
        }

        public void region_bake_navigation_mesh(ulong navigation_mesh, ulong root_node)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, navigation_mesh);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, root_node);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_bake_navigation_mesh__24__24__r0);
            Helpers.WaitForCompletion();
        }

        public long region_get_connections_count(ulong region)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_get_connections_count__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public Vector3 region_get_connection_pathway_start(ulong region, long connection)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, connection);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_get_connection_pathway_start__23__2__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public Vector3 region_get_connection_pathway_end(ulong region, long connection)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, connection);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_get_connection_pathway_end__23__2__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public Vector3 region_get_closest_point_to_segment(ulong region, Vector3 start, Vector3 end, bool use_collision)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, start);
            Helpers.WriteVector3(Commands.CMD_DATA + 28, end);
            Helpers.WriteInt32(Commands.CMD_DATA + 40, use_collision ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_get_closest_point_to_segment__23__9__9__1__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public Vector3 region_get_closest_point(ulong region, Vector3 to_point)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, to_point);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_get_closest_point__23__9__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public Vector3 region_get_closest_point_normal(ulong region, Vector3 to_point)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, to_point);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_get_closest_point_normal__23__9__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public Vector3 region_get_random_point(ulong region, long navigation_layers, bool uniformly)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, navigation_layers);
            Helpers.WriteInt32(Commands.CMD_DATA + 24, uniformly ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_get_random_point__23__2__1__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public AABB region_get_bounds(ulong region)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, region);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_region_get_bounds__23__r16);
            Helpers.WaitForCompletion();
            AABB result = Helpers.ReadAABB(Commands.CMD_DATA);
            return result;
        }

        public ulong link_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public long link_get_iteration_id(ulong link)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_get_iteration_id__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void link_set_map(ulong link, ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.WriteRID(Commands.CMD_DATA + 16, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_set_map__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong link_get_map(ulong link)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_get_map__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void link_set_enabled(ulong link, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_set_enabled__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool link_get_enabled(ulong link)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_get_enabled__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void link_set_bidirectional(ulong link, bool bidirectional)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, bidirectional ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_set_bidirectional__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool link_is_bidirectional(ulong link)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_is_bidirectional__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void link_set_navigation_layers(ulong link, long navigation_layers)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, navigation_layers);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_set_navigation_layers__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long link_get_navigation_layers(ulong link)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_get_navigation_layers__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void link_set_start_position(ulong link, Vector3 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, position);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_set_start_position__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 link_get_start_position(ulong link)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_get_start_position__23__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void link_set_end_position(ulong link, Vector3 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, position);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_set_end_position__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 link_get_end_position(ulong link)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_get_end_position__23__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void link_set_enter_cost(ulong link, double enter_cost)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, enter_cost);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_set_enter_cost__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double link_get_enter_cost(ulong link)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_get_enter_cost__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void link_set_travel_cost(ulong link, double travel_cost)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, travel_cost);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_set_travel_cost__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double link_get_travel_cost(ulong link)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_get_travel_cost__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void link_set_owner_id(ulong link, long owner_id)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, owner_id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_set_owner_id__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long link_get_owner_id(ulong link)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, link);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_link_get_owner_id__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public ulong agent_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void agent_set_avoidance_enabled(ulong agent, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_set_avoidance_enabled__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool agent_get_avoidance_enabled(ulong agent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_get_avoidance_enabled__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void agent_set_use_3d_avoidance(ulong agent, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_set_use_3d_avoidance__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool agent_get_use_3d_avoidance(ulong agent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_get_use_3d_avoidance__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void agent_set_map(ulong agent, ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.WriteRID(Commands.CMD_DATA + 16, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_set_map__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong agent_get_map(ulong agent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_get_map__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void agent_set_paused(ulong agent, bool paused)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, paused ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_set_paused__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool agent_get_paused(ulong agent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_get_paused__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void agent_set_neighbor_distance(ulong agent, double distance)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, distance);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_set_neighbor_distance__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double agent_get_neighbor_distance(ulong agent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_get_neighbor_distance__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void agent_set_max_neighbors(ulong agent, long count)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, count);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_set_max_neighbors__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long agent_get_max_neighbors(ulong agent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_get_max_neighbors__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void agent_set_time_horizon_agents(ulong agent, double time_horizon)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time_horizon);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_set_time_horizon_agents__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double agent_get_time_horizon_agents(ulong agent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_get_time_horizon_agents__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void agent_set_time_horizon_obstacles(ulong agent, double time_horizon)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, time_horizon);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_set_time_horizon_obstacles__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double agent_get_time_horizon_obstacles(ulong agent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_get_time_horizon_obstacles__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void agent_set_radius(ulong agent, double radius)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, radius);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_set_radius__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double agent_get_radius(ulong agent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_get_radius__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void agent_set_height(ulong agent, double height)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, height);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_set_height__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double agent_get_height(ulong agent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_get_height__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void agent_set_max_speed(ulong agent, double max_speed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, max_speed);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_set_max_speed__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double agent_get_max_speed(ulong agent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_get_max_speed__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void agent_set_velocity_forced(ulong agent, Vector3 velocity)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, velocity);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_set_velocity_forced__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public void agent_set_velocity(ulong agent, Vector3 velocity)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, velocity);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_set_velocity__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 agent_get_velocity(ulong agent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_get_velocity__23__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void agent_set_position(ulong agent, Vector3 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, position);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_set_position__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 agent_get_position(ulong agent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_get_position__23__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public bool agent_is_map_changed(ulong agent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_is_map_changed__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void agent_set_avoidance_callback(ulong agent, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.WriteCallable(Commands.CMD_DATA + 16, callback);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_set_avoidance_callback__23__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool agent_has_avoidance_callback(ulong agent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_has_avoidance_callback__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void agent_set_avoidance_layers(ulong agent, long layers)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, layers);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_set_avoidance_layers__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long agent_get_avoidance_layers(ulong agent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_get_avoidance_layers__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void agent_set_avoidance_mask(ulong agent, long mask)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, mask);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_set_avoidance_mask__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long agent_get_avoidance_mask(ulong agent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_get_avoidance_mask__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void agent_set_avoidance_priority(ulong agent, double priority)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, priority);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_set_avoidance_priority__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double agent_get_avoidance_priority(ulong agent)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, agent);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_agent_get_avoidance_priority__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public ulong obstacle_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void obstacle_set_avoidance_enabled(ulong obstacle, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_set_avoidance_enabled__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool obstacle_get_avoidance_enabled(ulong obstacle)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_get_avoidance_enabled__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void obstacle_set_use_3d_avoidance(ulong obstacle, bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_set_use_3d_avoidance__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool obstacle_get_use_3d_avoidance(ulong obstacle)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_get_use_3d_avoidance__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void obstacle_set_map(ulong obstacle, ulong map)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.WriteRID(Commands.CMD_DATA + 16, map);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_set_map__23__23__r0);
            Helpers.WaitForCompletion();
        }

        public ulong obstacle_get_map(ulong obstacle)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_get_map__23__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void obstacle_set_paused(ulong obstacle, bool paused)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, paused ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_set_paused__23__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool obstacle_get_paused(ulong obstacle)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_get_paused__23__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void obstacle_set_radius(ulong obstacle, double radius)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, radius);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_set_radius__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double obstacle_get_radius(ulong obstacle)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_get_radius__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void obstacle_set_height(ulong obstacle, double height)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.WriteDouble(Commands.CMD_DATA + 16, height);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_set_height__23__3__r0);
            Helpers.WaitForCompletion();
        }

        public double obstacle_get_height(ulong obstacle)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_get_height__23__r3);
            Helpers.WaitForCompletion();
            double result = Helpers.ReadDouble(Commands.CMD_DATA);
            return result;
        }

        public void obstacle_set_velocity(ulong obstacle, Vector3 velocity)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, velocity);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_set_velocity__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 obstacle_get_velocity(ulong obstacle)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_get_velocity__23__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void obstacle_set_position(ulong obstacle, Vector3 position)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.WriteVector3(Commands.CMD_DATA + 16, position);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_set_position__23__9__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3 obstacle_get_position(ulong obstacle)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_get_position__23__r9);
            Helpers.WaitForCompletion();
            Vector3 result = Helpers.ReadVector3(Commands.CMD_DATA);
            return result;
        }

        public void obstacle_set_vertices(ulong obstacle, Vector3[] vertices)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.WritePackedVector3Array(Commands.CMD_DATA + 16, vertices);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_set_vertices__23__36__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3[] obstacle_get_vertices(ulong obstacle)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_get_vertices__23__r36);
            Helpers.WaitForCompletion();
            Vector3[] result = Helpers.ReadPackedVector3Array(Commands.CMD_DATA);
            return result;
        }

        public void obstacle_set_avoidance_layers(ulong obstacle, long layers)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.WriteInt64(Commands.CMD_DATA + 16, layers);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_set_avoidance_layers__23__2__r0);
            Helpers.WaitForCompletion();
        }

        public long obstacle_get_avoidance_layers(ulong obstacle)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, obstacle);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_obstacle_get_avoidance_layers__23__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void parse_source_geometry_data(ulong navigation_mesh, ulong source_geometry_data, ulong root_node, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, navigation_mesh);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, source_geometry_data);
            Helpers.WriteUInt64(Commands.CMD_DATA + 24, root_node);
            Helpers.WriteCallable(Commands.CMD_DATA + 32, callback);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_parse_source_geometry_data__24__24__24__25__r0);
            Helpers.WaitForCompletion();
        }

        public void bake_from_source_geometry_data(ulong navigation_mesh, ulong source_geometry_data, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, navigation_mesh);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, source_geometry_data);
            Helpers.WriteCallable(Commands.CMD_DATA + 24, callback);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_bake_from_source_geometry_data__24__24__25__r0);
            Helpers.WaitForCompletion();
        }

        public void bake_from_source_geometry_data_async(ulong navigation_mesh, ulong source_geometry_data, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, navigation_mesh);
            Helpers.WriteUInt64(Commands.CMD_DATA + 16, source_geometry_data);
            Helpers.WriteCallable(Commands.CMD_DATA + 24, callback);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_bake_from_source_geometry_data_async__24__24__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_baking_navigation_mesh(ulong navigation_mesh)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteUInt64(Commands.CMD_DATA + 8, navigation_mesh);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_is_baking_navigation_mesh__24__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public ulong source_geometry_parser_create()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_source_geometry_parser_create__r23);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadRID(Commands.CMD_DATA);
            return result;
        }

        public void source_geometry_parser_set_callback(ulong parser, object callback)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, parser);
            Helpers.WriteCallable(Commands.CMD_DATA + 16, callback);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_source_geometry_parser_set_callback__23__25__r0);
            Helpers.WaitForCompletion();
        }

        public Vector3[] simplify_path(Vector3[] path, double epsilon)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WritePackedVector3Array(Commands.CMD_DATA + 8, path);
            Helpers.WriteDouble(Commands.CMD_DATA + 8, epsilon);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_simplify_path__36__3__r36);
            Helpers.WaitForCompletion();
            Vector3[] result = Helpers.ReadPackedVector3Array(Commands.CMD_DATA);
            return result;
        }

        public void free_rid(ulong rid)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteRID(Commands.CMD_DATA + 8, rid);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_free_rid__23__r0);
            Helpers.WaitForCompletion();
        }

        public void set_active(bool active)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, active ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_set_active__1__r0);
            Helpers.WaitForCompletion();
        }

        public void set_debug_enabled(bool enabled)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enabled ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_set_debug_enabled__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool get_debug_enabled()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_get_debug_enabled__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_process_info(long process_info)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, process_info);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_get_process_info__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_free__r0);
            Helpers.WaitForCompletion();
        }

        public void _init()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D__init__r0);
            Helpers.WaitForCompletion();
        }

        public string _to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D__to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public void _notification(long what)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D__notification__2__r0);
            Helpers.WaitForCompletion();
        }

        public bool _set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D__set__21__0__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D__get__21__r0);
            Helpers.WaitForCompletion();
        }

        public object _get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D__get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void _validate_property(object property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteDictionary(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D__validate_property__27__r0);
            Helpers.WaitForCompletion();
        }

        public bool _property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D__property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D__property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool _iter_init(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D__iter_init__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool _iter_next(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteArray(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D__iter_next__28__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void _iter_get(object iter)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, iter);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D__iter_get__0__r0);
            Helpers.WaitForCompletion();
        }

        public string get_class()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_get_class__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public bool is_class(string class_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, class_);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_is_class__4__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_set__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_get__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_indexed(string property_path, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_set_indexed__22__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_indexed(string property_path)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteNodePath(Commands.CMD_DATA + 8, property_path);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_get_indexed__22__r0);
            Helpers.WaitForCompletion();
        }

        public object get_property_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_get_property_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_method_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_get_method_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public bool property_can_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_property_can_revert__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void property_get_revert(string property)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_property_get_revert__21__r0);
            Helpers.WaitForCompletion();
        }

        public void notification(long what, bool reversed)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt64(Commands.CMD_DATA + 8, what);
            Helpers.WriteInt32(Commands.CMD_DATA + 16, reversed ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_notification__2__1__r0);
            Helpers.WaitForCompletion();
        }

        public string to_string()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_to_string__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public ulong get_instance_id()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_get_instance_id__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

        public void set_script(object script)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteVariant(Commands.CMD_DATA + 8, script);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_set_script__0__r0);
            Helpers.WaitForCompletion();
        }

        public void get_script()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_get_script__r0);
            Helpers.WaitForCompletion();
        }

        public void set_meta(string name, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_set_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void remove_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_remove_meta__21__r0);
            Helpers.WaitForCompletion();
        }

        public void get_meta(string name, object default_)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, default_);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_get_meta__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_meta(string name)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, name);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_has_meta__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_meta_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_get_meta_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public void add_user_signal(string signal, object arguments)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteString(Commands.CMD_DATA + 8, signal);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arguments);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_add_user_signal__4__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_has_user_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void remove_user_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_remove_user_signal__21__r0);
            Helpers.WaitForCompletion();
        }

        public long emit_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_emit_signal__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void call(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_call__21__r0);
            Helpers.WaitForCompletion();
        }

        public void call_deferred(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_call_deferred__21__r0);
            Helpers.WaitForCompletion();
        }

        public void set_deferred(string property, object value)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, property);
            Helpers.WriteVariant(Commands.CMD_DATA + 1036, value);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_set_deferred__21__0__r0);
            Helpers.WaitForCompletion();
        }

        public void callv(string method, object arg_array)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.WriteArray(Commands.CMD_DATA + 1036, arg_array);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_callv__21__28__r0);
            Helpers.WaitForCompletion();
        }

        public bool has_method(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_has_method__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public long get_method_argument_count(string method)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, method);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_get_method_argument_count__21__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public bool has_signal(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_has_signal__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public object get_signal_list()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_get_signal_list__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_signal_connection_list(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_get_signal_connection_list__21__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public object get_incoming_connections()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_get_incoming_connections__r28);
            Helpers.WaitForCompletion();
            object result = Helpers.ReadArray(Commands.CMD_DATA);
            return result;
        }

        public long connect(string signal, object callable, long flags)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.WriteInt64(Commands.CMD_DATA + 1036, flags);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_connect__21__25__2__r2);
            Helpers.WaitForCompletion();
            long result = Helpers.ReadInt64(Commands.CMD_DATA);
            return result;
        }

        public void disconnect(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_disconnect__21__25__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_connected(string signal, object callable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.WriteCallable(Commands.CMD_DATA + 1036, callable);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_is_connected__21__25__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public bool has_connections(string signal)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, signal);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_has_connections__21__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void set_block_signals(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_set_block_signals__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_blocking_signals()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_is_blocking_signals__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void notify_property_list_changed()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_notify_property_list_changed__r0);
            Helpers.WaitForCompletion();
        }

        public void set_message_translation(bool enable)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteInt32(Commands.CMD_DATA + 8, enable ? 1 : 0);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_set_message_translation__1__r0);
            Helpers.WaitForCompletion();
        }

        public bool can_translate_messages()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_can_translate_messages__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public string tr(string message, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, context);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_tr__21__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string tr_n(string message, string plural_message, long n, string context)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, message);
            Helpers.WriteStringName(Commands.CMD_DATA + 1036, plural_message);
            Helpers.WriteInt64(Commands.CMD_DATA + 2064, n);
            Helpers.WriteStringName(Commands.CMD_DATA + 2072, context);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_tr_n__21__21__2__21__r4);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadString(Commands.CMD_DATA);
            return result;
        }

        public string get_translation_domain()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_get_translation_domain__r21);
            Helpers.WaitForCompletion();
            string result = Helpers.ReadStringName(Commands.CMD_DATA);
            return result;
        }

        public void set_translation_domain(string domain)
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.WriteStringName(Commands.CMD_DATA + 8, domain);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_set_translation_domain__21__r0);
            Helpers.WaitForCompletion();
        }

        public bool is_queued_for_deletion()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_is_queued_for_deletion__r1);
            Helpers.WaitForCompletion();
            bool result = Helpers.ReadInt32(Commands.CMD_DATA) != 0;
            return result;
        }

        public void cancel_free()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_cancel_free__r0);
            Helpers.WaitForCompletion();
        }

        public ulong get_singleton()
        {
            Helpers.WriteUInt64(Commands.CMD_DATA, Id);
            Helpers.SendCommand(Commands.CMD_NavigationServer3D_get_singleton__r24);
            Helpers.WaitForCompletion();
            ulong result = Helpers.ReadUInt64(Commands.CMD_DATA);
            return result;
        }

    }
}
