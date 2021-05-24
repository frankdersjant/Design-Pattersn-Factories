namespace ConsoleAppAbstractFactory.Models
{
    public class MazeFactory
    {
        public virtual Maze MakeMaze() { return new Maze(); }
        public virtual Wall MakeWall() { return new Wall(); }
        public virtual Door MakeDoor(Room r1, Room r2) { return new Door(r1, r2); }
        public virtual Room MakeRoom(int nr) { return new Room(nr); }
       
    }
}
