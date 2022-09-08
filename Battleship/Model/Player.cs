namespace Battleship.Model
{
    public class Player
    {
        public List<Ship> Ships = new List<Ship>(5);
        public bool IsAlive
        {
            get
            {
                if (Ships == null) return false;
                return true;
            }
        }
    }
}

    