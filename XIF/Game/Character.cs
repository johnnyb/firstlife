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

        public List<string> GetAvailableActions(Character ch)
        {
            throw new NotImplementedException();
        }

        public List<string> GetModifiersForAction(Character ch, string action)
        {
            throw new NotImplementedException();
        }

        public List<IGameObject> GetValidObjectsForModifier(Character ch, string action, string modifier)
        {
            throw new NotImplementedException();
        }

        public string PerformAction(Character ch, string action, IDictionary<string, IGameObject> modifiers)
        {
            throw new NotImplementedException();
        }
    }
}
