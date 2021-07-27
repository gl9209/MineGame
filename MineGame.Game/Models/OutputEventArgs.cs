using MineGame.Game.Enums;

using System;

namespace MineGame.Game.Models
{
    public class OutputEventArgs : EventArgs
    {
        internal OutputEventArgs(
            Output outputEnum,
            Location location = null,
            int? lives = null,
            Dimensions dimensions = null,
            int? moves = null)
        {
            Output = outputEnum;
            Location = location;
            Lives = lives;
            Dimensions = dimensions;
            Moves = moves;
        }

        public Location Location { get; }
        public int? Lives { get; }
        public Dimensions Dimensions { get; }
        public int? Moves { get; }
        public Output Output { get; }
    }
}