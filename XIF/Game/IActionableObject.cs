using System;
using System.Collections.Generic;
namespace XIF.Game
{
    public interface IActionableObject : IGameObject
    {
        List<string> GetAvailableActions(Character ch);
        List<string> GetModifiersForAction(Character ch, string action);
        List<IGameObject> GetValidObjectsForModifier(Character ch, string action, string modifier);
        string PerformAction(Character ch, string action, IDictionary<string, IGameObject> modifiers);
    }
}
