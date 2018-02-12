using System;
using System.Collections.Generic;

namespace XIF.Game
{
    public class Map
    {
        public string Name { get; set; } = "Unnamed Map";
        public List<Room> EntryPoints { get; set; } = new List<Room>();


        public List<Room> GetAllRooms()
        {
            var all_rooms = new List<Room>();
            foreach (var entry_point in EntryPoints)
            {
                GetAllRoomsFromStartingPoint(entry_point, all_rooms);
            }

            return all_rooms;
        }

        private void GetAllRoomsFromStartingPoint(Room r, List<Room> current_list)
        {
            if (current_list.Contains(r))
            {
                return;
            }
            else
            {
                current_list.Add(r);
                foreach (var door in r.Doorways)
                {
                    GetAllRoomsFromStartingPoint(door.Destination, current_list);
                }
            }
        }

        public Map()
        {
        }
    }
}
