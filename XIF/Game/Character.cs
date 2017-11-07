using System;
using System.Collections.Generic;
namespace XIF.Game
{
    public class Character : IActionableObject
    {
        public string Name { get; set; } = "Unnamed Character";
        public int Health { get; set; } = 100;
        public Room Location { get; set; }
        public List<IActionableObject> InventoryItems { get; set; } = new List<IActionableObject>();

        public bool CanBeTaken => false;

        public Character()
        {
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
    }
}
