namespace ConsoleAppAbstractFactory.Models
{
    public class EnchantedMazeFactory : MazeFactory
    {
        public EnchantedMazeFactory()
        {

        }

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
