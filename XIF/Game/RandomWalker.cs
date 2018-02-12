using System;
namespace XIF.Game
{
    public class RandomWalker : Character
    {
        public RandomWalker()
        {
        }

        public override void AfterTurnAutomaticAction(Game g)
        {
            var rnd = g.RandomGenerator.NextDouble();
            if (rnd < 0.333)
            {
                var possible_moves = Location.GetActiveDoorways();
                var door_choice = (int)Math.Round(g.RandomGenerator.NextDouble() * (possible_moves.Count - 1));
                var door = possible_moves[door_choice];

                var original_room = Location;
                original_room.Characters.Remove(this);
                door.Destination.Characters.Add(this);
                Location = door.Destination;
            }
        }
    }
}
