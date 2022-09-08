namespace Battleship.Model
{
    public class Ship
    {
        
        public List<Square> SquareList;
        public ShipType Name { get; set; }

        public bool SunkState()
        {
            int shipLength = SquareList.Count-1;
            foreach (Square square in SquareList)
                if (square.SquareStatus == SquareStatus.Hit) 
                    shipLength -= 1;

            if (shipLength == 0)
                return true;
            return false;
        }
    }
}

