namespace ConsoleAppFactoryMethod.Models
{
    public class EnchantedMazeGame : MazeGame
    {
        public override Room MakeRoom(int nr)
        {
            return new EnchantedRoom(nr);
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            return new EnchantedDoor(r1, r2);
        }
    }
}
