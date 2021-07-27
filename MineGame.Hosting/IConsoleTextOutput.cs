using MineGame.Game.Models;

namespace MineGame.Hosting
{
    public interface IConsoleTextOutput
    {
        string Convert(OutputEventArgs e);
    }
}