namespace ConsoleAppAbstractFactory.Models
{
    public class BombedMazeFactory : MazeFactory
    {
        public BombedMazeFactory()
        {
        }


        public override Wall MakeWall()
        {
            return new BombedWall();
        }

        public override Room MakeRoom(int nr)
        {
            return new RoomWithABomb(nr);
        }
    }
}
