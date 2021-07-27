using MineGame.Game.Models;
using MineGame.Game.Settings;

namespace MineGame.Game
{
    internal class PositionChecker
    {
        internal static bool IsLegal(Dimensions dimensions, Location newPosition)
        {
            if (newPosition.Column < 0 || newPosition.Column > dimensions.Width - 1)
            {
                return false;
            }
            if (newPosition.Row < 0 || newPosition.Row > dimensions.Height - 1)
            {
                return false;
            }
            return true;
        }
    }
}