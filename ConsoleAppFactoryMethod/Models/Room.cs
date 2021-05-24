namespace ConsoleAppFactoryMethod.Models
{
    public class Room
    {
        public int RoomNumber { get; private set; }
        public Wall Wall { get; private set; }
        public Room(int RN)
        {
            RoomNumber = RN;
        }

        public void Enter()
        { }

        public void SetSide(enumDirection direction, Wall wall)
        { }

        public void SetSide(enumDirection direction, Door door)
        { }
    }
}
