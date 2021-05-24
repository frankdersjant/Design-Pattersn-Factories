namespace ConsoleAppAbstractFactory.Models
{
    public class MazeGame
    {
        public void CreateMaze(MazeFactory mazeFactory) 
        {
            Maze maze = mazeFactory.MakeMaze();

            Room r1 = mazeFactory.MakeRoom(1);
            Room r2 = mazeFactory.MakeRoom(2);

            Door thegreenDoor = mazeFactory.MakeDoor(r1, r2);
            maze.AddRoom(r1);
            maze.AddRoom(r2);

            Wall w = mazeFactory.MakeWall();

            r1.SetSide(enumDirection.North, mazeFactory.MakeWall());
            r1.SetSide(enumDirection.East, thegreenDoor);
            r1.SetSide(enumDirection.South, mazeFactory.MakeWall());
            r1.SetSide(enumDirection.West, mazeFactory.MakeWall());

            r2.SetSide(enumDirection.North, mazeFactory.MakeWall());
            r2.SetSide(enumDirection.East, mazeFactory.MakeWall());
            r2.SetSide(enumDirection.South, mazeFactory.MakeWall());
            r2.SetSide(enumDirection.West, thegreenDoor);
        }
    }
}
