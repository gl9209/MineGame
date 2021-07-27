﻿using MineGame.Game.Enums;

using System;

namespace MineGame.Hosting
{
    public class StandardKeyMap : IKeyMap
    {
        public Input Convert(ConsoleKey key) =>
            key switch
            {
                ConsoleKey.F5 => Input.Reset,
                ConsoleKey.F4 => Input.Exit,
                ConsoleKey.LeftArrow => Input.Left,
                ConsoleKey.RightArrow => Input.Right,
                ConsoleKey.UpArrow => Input.Up,
                ConsoleKey.DownArrow => Input.Down,
                _ => Input.None
            };
    }
}