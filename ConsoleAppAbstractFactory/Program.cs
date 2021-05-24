using ConsoleAppAbstractFactory.Models;
using System;

namespace ConsoleAppAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame mazeGame = new MazeGame();
            MazeFactory mazefactory = new BombedMazeFactory();

            mazeGame.CreateMaze(mazefactory);

            
        }
    }
}
