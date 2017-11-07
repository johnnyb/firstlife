using System;
namespace XIF.Game
{
    public class Doorway
    {
        public string Direction { get; set; }
        public Room Destination { get; set; }
        public Doorway()
        {
        }

        public static void CreateTwoWayDoor(Room rm1, Room rm2, string direction1, string direction2 = null) {
            var dw1 = new Doorway { Destination = rm2, Direction = direction1 };
            rm1.Doorways.Add(dw1);
            var dw2 = new Doorway { Destination = rm1, Direction = direction2 };
            rm2.Doorways.Add(dw2);
        }
    }
}
