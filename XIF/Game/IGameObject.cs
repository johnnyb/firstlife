using System;
namespace XIF.Game
{
    public interface IGameObject
    {
        string Name { get; }
        bool CanBeTaken { get; }
    }
}
