using System;
using System.Collections.Generic;
namespace XIF.Game
{
    public class Character : IActionableObject
    {
        public virtual string Name { get; set; } = "Unnamed Character";
        public virtual int Health { get; set; } = 100;
        public virtual Room Location { get; set; }
        public virtual List<IActionableObject> InventoryItems { get; set; } = new List<IActionableObject>();

        public virtual bool CanBeTaken => false;

        public Character()
        {
        }

        public virtual List<string> GetAvailableActions(Character ch)
        {
            throw new NotImplementedException();
        }

        public virtual List<string> GetModifiersForAction(Character ch, string action)
        {
            throw new NotImplementedException();
        }

        public virtual List<IGameObject> GetValidObjectsForModifier(Character ch, string action, string modifier)
        {
            throw new NotImplementedException();
        }

        public virtual string PerformAction(Character ch, string action, IDictionary<string, IGameObject> modifiers)
        {
            throw new NotImplementedException();
        }

        public virtual void AfterTurnAutomaticAction(Game g)
        {
        }
    }
}
