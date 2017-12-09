using System;
using System.Collections.Generic;

namespace XIF.Game
{
    public class EdibleObject : BasicObject
    {
        public EdibleObject()
        {
      
        }

        public override List<string> GetAvailableActions(Character ch)
        {
            
            var actions = new List<string>();
            actions.Add("Eat");

            actions.AddRange(base.GetAvailableActions(ch));
            return actions;
        }

        public override string PerformAction(Character ch, string action, IDictionary<string, IGameObject> modifiers)
        {
            if (action == "Eat")
            {
                if (ch.InventoryItems.Contains(this))
                {
                    ch.InventoryItems.Remove(this);
                }
                else if(ch.Location.Items.Contains(this))
                {
                    ch.Location.Items.Remove(this);
                }

                return "Your stomach is now satisfied.";
            }
            else
            {
                return base.PerformAction(ch, action, modifiers);
            }
        }
    }
}
