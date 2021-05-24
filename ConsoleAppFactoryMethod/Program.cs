using ConsoleAppFactoryMethod.Models;

namespace ConsoleAppFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame mazeGame = new MazeGame();
            mazeGame.createMaze();

        }
    }
}
