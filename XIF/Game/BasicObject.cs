using System;
using System.Collections.Generic;

namespace XIF.Game
{
    public class BasicObject : IActionableObject
    {
        public string Name { get; set; } = "Unnamed Object";
        public bool CanBeTaken { get; set; } = true;

        public BasicObject()
        {

        }

        public List<string> GetAvailableActions(Character ch)
        {
            return new List<string>();
        }

        public List<string> GetModifiersForAction(Character ch, string action)
        {
            return new List<string>();
        }

        public List<IGameObject> GetValidObjectsForModifier(Character ch, string action, string modifier)
        {
            return new List<IGameObject>();
        }

        public string PerformAction(Character ch, string action, IDictionary<string, IGameObject> modifiers)
        {
            return null;
        }
    }
}
