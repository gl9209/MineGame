using MineGame.Game;
using MineGame.Game.Enums;

using System;

namespace MineGame.Hosting
{
    public interface IKeyMap
    {
        Input Convert(ConsoleKey key);
    }
}