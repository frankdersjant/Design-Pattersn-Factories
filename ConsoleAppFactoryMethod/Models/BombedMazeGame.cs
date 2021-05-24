namespace ConsoleAppFactoryMethod.Models
{
    public class BombedMazeGame : MazeGame
    {
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
