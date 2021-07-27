using MineGame.Game.Models;
using MineGame.Game.Settings;

namespace MineGame.Game
{
    public class PositionChecker
    {
        private GameSettings settings;

        public PositionChecker(GameSettings settings)
        {
            this.settings = settings;
        }

        internal bool IsLegal(Location newPosition)
        {
            if (newPosition.Column < 0 || newPosition.Column > settings.Dimensions.Width - 1)
            {
                return false;
            }
            if (newPosition.Row < 0 || newPosition.Row > settings.Dimensions.Height - 1)
            {
                return false;
            }
            return true;
        }
    }
}