using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace XIF.Game
{
    public class Room : IActionableObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ImageSource DisplayImage { get; set; }

        // I had *thought* that DisplayImage would auto-find the calling assembly, but I couldn't get it to work.
        // This utilizes the Game ResourceAssembly for loading.
        public string DisplayImageResourcePath
        {
            set
            {
                DisplayImage = ImageSource.FromResource(value, Game.ResourceAssembly);
            }
        }
        public List<Doorway> Doorways { get; set; } = new List<Doorway>();
        public List<IActionableObject> Items { get; set; } = new List<IActionableObject>();
        public List<Character> Characters { get; set; } = new List<Character>();

        public bool CanBeTaken => false;

        public List<Doorway> GetActiveDoorways() {
            return Doorways;
        }

        public List<IActionableObject> GetVisibleItems() {
            return Items;
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

        public virtual void AfterTurnAutomaticAction(Game g)
        {
        }

        public Room()
        {
           
        }
    }
}

