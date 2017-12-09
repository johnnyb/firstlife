using System;
using System.Collections.Generic;

namespace XIF.Game
{
    public class BasicObject : IActionableObject
    {
        public virtual string Name { get; set; } = "Unnamed Object";
        public virtual bool CanBeTaken { get; set; } = true;

        public BasicObject()
        {

        }

        public virtual List<string> GetAvailableActions(Character ch)
        {
            return new List<string>();
        }

        public virtual List<string> GetModifiersForAction(Character ch, string action)
        {
            return new List<string>();
        }

        public virtual List<IGameObject> GetValidObjectsForModifier(Character ch, string action, string modifier)
        {
            return new List<IGameObject>();
        }

        public virtual string PerformAction(Character ch, string action, IDictionary<string, IGameObject> modifiers)
        {
            return null;
        }
    }
}
