﻿using System;

namespace Kata
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IRandomGenerator randomGenerator = new RandomGenerator();
            var board = new Board(3, randomGenerator);
            var game = new GridDisplayer(board);
            while (!game.GameIsOver)
            {
                Console.Write(game.DisplayBoard());
                var input = Console.ReadKey().KeyChar.ToString();
                game.SelectColumn(input);
                Console.Clear();
            }
            Console.Write(game.DisplayBoard());
        }
    }
}