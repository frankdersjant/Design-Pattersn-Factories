using ConsoleAppFactoryMethod.Models;

namespace ConsoleAppFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
        
            //aka Virtal Constructor
            //makes a single product(type)
            //Uses inheritance to instantiate objects
            //Is a single method
            //IDEA: Interface but subclasses decide object to instantiate

            MazeGame mazeGame = new EnchantedMazeGame();
            mazeGame.createMaze();

        }
    }
}
