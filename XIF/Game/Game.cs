using System;
using System.Collections.Generic;

namespace XIF.Game
{
    public class Game : Xamarin.Forms.Element
    {
        public Random RandomGenerator { get; set; } = new Random();
        public Character MainCharacter { get; set; }
        public List<Map> Maps { get; set; } = new List<Map>();
        public List<Character> Characters { get; set; } = new List<Character>();

        public Game()
        {
            
        }

        public void Initialize()
        {
            // Synchronize rooms and characters

            foreach (var ch in Characters)
            {
                if (!ch.Location.Characters.Contains(ch))
                {
                    ch.Location.Characters.Add(ch);
                }
            }
            foreach (var map in Maps)
            {
                foreach (var rm in map.Rooms)
                {
                    foreach (var ch in rm.Characters)
                    {
                        ch.Location = rm;
                    }
                }
            }
        }

        public void PerformAutomaticActions()
        {
            foreach (var map in Maps)
            {
                foreach (var room in map.Rooms)
                {
                    // ** NOTE - we are converting these lists to arrays before 
                    //           iterating through them so that, if they are 
                    //           modified while in-progress, nothing bad will 
                    //           happen.  However, for things that move around, 
                    //           it is possible that their after-action updates 
                    //           may occur more than once if they are moved to 
                    //           a room further down the list.  To avoid this, 
                    //           perhaps we should instead have all of these  
                    //           objects add their actions to a separate 
                    //           movement queue which is then handled.
                    foreach (var character in room.Characters.ToArray())
                    {
                        character.AfterTurnAutomaticAction(this);
                    }
                    foreach (var item in room.Items.ToArray())
                    {
                        item.AfterTurnAutomaticAction(this);
                    }
                }
            }
        }
    }
}
