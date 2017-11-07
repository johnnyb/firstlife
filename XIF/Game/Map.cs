using System;
using System.Collections.Generic;

namespace XIF.Game
{
    public class Map
    {
        public string Name { get; set; } = "Unnamed Map";
        public List<Room> EntryPoints { get; set; } = new List<Room>();
        public Map()
        {
        }
    }
}
