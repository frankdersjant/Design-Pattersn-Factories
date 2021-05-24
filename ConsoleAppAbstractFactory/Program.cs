using ConsoleAppAbstractFactory.Models;

namespace ConsoleAppAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aka Super Factory or Factory of factories
            //Make families of related products
            //Uses composition to create objects
            //IDEA: create a family of related object without specifying their concrete class

            MazeGame mazeGame = new MazeGame();
            MazeFactory mazefactory = new BombedMazeFactory();

            mazeGame.CreateMaze(mazefactory);

            
        }
    }
}
