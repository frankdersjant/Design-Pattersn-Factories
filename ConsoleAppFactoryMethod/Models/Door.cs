namespace ConsoleAppFactoryMethod.Models
{
    public class Door
    {
        private Room roomfirst;
        private Room roomsecond;
        public Door(Room roomFirst, Room roomSecond)
        {
            roomfirst = roomFirst;
            roomsecond = roomSecond;
        }
    }
}
