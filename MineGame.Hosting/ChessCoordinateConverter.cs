using MineGame.Game.Models;

using System;

namespace MineGame.Hosting
{
    public class ChessCoordinateConverter : ICoordinateConverter
    {
        private const int UpperCaseAUnicode = 65;

        public string Convert(Location location)
        {
            if (location.Column > 25)
            {
                throw new ArgumentException($"{location.Column} does not convert to letter");
            }
            var chessColumn = (char)(UpperCaseAUnicode + location.Column);
            var chessRow = (location.Row + 1).ToString();
            return chessColumn + chessRow;
        }
    }
}