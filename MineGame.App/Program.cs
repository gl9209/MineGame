using Microsoft.Extensions.DependencyInjection;

using MineGame.Game;
using MineGame.Game.Settings;
using MineGame.Hosting;

using System;

namespace MineGame.App
{
    internal class Program
    {
        private static void Main()
        {
            var settings = new GameSettings
            {
                Dimensions = new Dimensions(Width: 8, Height: 8),
                MineCountRange = new MineCountRange(Minimum: 4, Maximum: 6),
                Lives = 3
            };

            var serviceProvider = new ServiceCollection()
                .AddSingleton(settings)
                .AddSingleton<Random>()
                .AddSingleton<Minelayer>()
                .AddSingleton<PositionChecker>()
                .AddSingleton<GameEngine>()
                .AddSingleton<ICoordinateConverter, ChessCoordinateConverter>()
                .AddSingleton<IConsoleTextOutput, MinimalConsoleTextOutput>()
                .AddSingleton<IKeyMap, StandardKeyMap>()
                .AddSingleton<ConsoleHost>()
                .BuildServiceProvider();

            var host = serviceProvider.GetService<ConsoleHost>();

            host.Run();
        }
    }
}