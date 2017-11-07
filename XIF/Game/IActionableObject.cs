using System;
using System.Collections.Generic;
namespace XIF.Game
{
    public interface IActionableObject : IGameObject
    {
        List<string> GetAvailableActions();
        List<string> GetModifiersForAction(string action);
        List<IGameObject> GetValidObjectsForModifier(string action, string modifier, Character ch);
    }
}
