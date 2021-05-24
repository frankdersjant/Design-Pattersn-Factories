namespace ConsoleAppFactoryMethod.Models
{
    public class MazeGame
    {
        public Maze createMaze()
        {
            Maze maze = MakeMaze();

            Room r1 = MakeRoom(1);
            Room r2 = MakeRoom(2);

            Door thegreenDoor = MakeDoor(r1, r2);
            maze.AddRoom(r1);
            maze.AddRoom(r2);

            r1.SetSide(enumDirection.North, MakeWall());
            r1.SetSide(enumDirection.East, thegreenDoor);
            r1.SetSide(enumDirection.South, MakeWall());
            r1.SetSide(enumDirection.West, MakeWall());

            r2.SetSide(enumDirection.North, new Wall());
            r2.SetSide(enumDirection.East, new Wall());
            r2.SetSide(enumDirection.South, new Wall());
            r2.SetSide(enumDirection.West, new Wall());

            return maze;
        }

        public virtual Maze MakeMaze() { return new Maze(); }
        public virtual Room MakeRoom(int nr) { return new Room(nr); }
        public virtual Wall MakeWall() { return new Wall(); }
        public virtual Door MakeDoor(Room r1, Room r2) { return new Door(r1, r2); }
    }
}
