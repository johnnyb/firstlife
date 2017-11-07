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

        public List<string> GetAvailableActions()
        {
            return new List<string>();
        }

        public List<string> GetModifiersForAction(string action)
        {
            return new List<string>();
        }

        public List<IGameObject> GetValidObjectsForModifier(string action, string modifier, Character ch)
        {
            return new List<IGameObject>();
        }
    }
}
