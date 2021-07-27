using MineGame.Game.Models;

namespace MineGame.Hosting
{
    public interface ICoordinateConverter
    {
        string Convert(Location location);
    }
}