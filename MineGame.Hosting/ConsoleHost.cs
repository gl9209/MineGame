using MineGame.Game;
using MineGame.Game.Enums;
using MineGame.Game.Models;

using static System.Console;


namespace MineGame.Hosting
{
    public class ConsoleHost
    {
        private GameEngine gameEngine;
        private IKeyMap keyMap;
        private IConsoleTextOutput consoleTextOutput;
        private bool exit;

        public ConsoleHost(GameEngine gameEngine, IKeyMap keyMap, IConsoleTextOutput consoleTextOutput)
        {
            this.gameEngine = gameEngine;
            this.keyMap = keyMap;
            this.consoleTextOutput = consoleTextOutput;
            this.gameEngine.OutputEmmited += HandleOutput;
        }

        private void HandleOutput(object sender, OutputEventArgs e)
        {
            
            Write(consoleTextOutput.Convert(e));
            if (e.Output == Output.Exited)
            {
                exit = true;
            }
        }

        public void Run()
        {
            gameEngine.Start();
            while (!exit)
            {
                gameEngine.ReceiveInput(keyMap.Convert(ReadKey().Key));
            }
            
        }
    }
}