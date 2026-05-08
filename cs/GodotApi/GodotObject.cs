using System;

namespace GodotWeb
{
    public class GodotObject
    {
        public ulong Id { get; protected set; }

        public GodotObject(ulong id)
        {
            Id = id;
        }
    }
}
