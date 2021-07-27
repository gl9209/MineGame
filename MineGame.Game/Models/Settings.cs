using MineGame.Game.Models;

namespace MineGame.Game
{
    public class Settings
    {
        public Dimensions Dimensions { get; set; }
        public MineCountRange MineCountRange { get; set; }
        public int Lives { get; set; }
    }
}