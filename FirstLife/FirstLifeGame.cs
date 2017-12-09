using System;
using XIF.Game;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FirstLife
{
    public class FirstLifeGame : XIF.Game.Game
    {
        public FirstLifeGame()
        {
            var living_room = new Room { 
                Name = "Living Room", 
                Description = "This is your living room, which you haven't cleaned in weeks.", 
                DisplayImage = ImageSource.FromResource("FirstLife.Resources.RoomImages.LivingRoom.png") 
            };

            var bedroom = new Room { Name = "Bedroom" };
            var watch = new BasicObject { Name = "Watch" };
            bedroom.Items.Add(watch);

            var kitchen = new Room { Name = "Kitchen" };
            var banana = new EdibleObject { Name = "Banana" };
            kitchen.Items.Add(banana);
            var apple = new EdibleObject { Name = "Apple" };
            kitchen.Items.Add(apple);
            var pear = new EdibleObject { Name = "Pear" };
            kitchen.Items.Add(pear);
            var filet = new EdibleObject { Name = "Filet Mignon" };
            kitchen.Items.Add(filet);

            var hallway = new Room { Name = "Hallway" };

            var bathroom = new Room { Name = "Bathroom" };

            Doorway.CreateTwoWayDoor(living_room, kitchen, "North", "South");
            Doorway.CreateTwoWayDoor(living_room, bedroom, "South", "North");
            Doorway.CreateTwoWayDoor(living_room, hallway, "East", "West");
            Doorway.CreateTwoWayDoor(living_room, bathroom, "West", "East");


            var hotel_map = new Map
            {
                EntryPoints = new List<Room> { living_room }
            };


            var character = new Character();
            character.Location = living_room;

            this.MainCharacter = character;
            this.Maps = new List<Map> { hotel_map };
        }
    }
}
