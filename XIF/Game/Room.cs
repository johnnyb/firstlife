using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XIF.Game
{
    public class Room : IActionableObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ImageSource DisplayImage { get; set; }
        public List<Doorway> Doorways { get; set; } = new List<Doorway>();
        public List<IActionableObject> Items { get; set; } = new List<IActionableObject>();
        public List<Character> Characters { get; set; } = new List<Character>();

        public bool CanBeTaken => false;

        public List<Doorway> GetActiveDoorways() {
            return Doorways;
        }

        public List<IActionableObject> GetVisibleItems() {
            return Items;
        }

        public List<string> GetAvailableActions()
        {
            throw new NotImplementedException();
        }

        public List<string> GetModifiersForAction(string action)
        {
            throw new NotImplementedException();
        }

        public List<IGameObject> GetValidObjectsForModifier(string action, string modifier, Character ch)
        {
            throw new NotImplementedException();
        }

        public Room()
        {
           
        }
    }
}

