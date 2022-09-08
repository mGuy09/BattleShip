namespace Battleship.Model
{
    public class Player
    {
        public List<Ship> Ships = new List<Ship>(4);
        public bool IsAlive
        {
            get
            {
                if (Ships == null) return false;
                return true;
            }
        }

        public void Shoot(Board board, (int,int) coords)
        {
            if (board.ocean[coords.Item1, coords.Item2].SquareStatus == SquareStatus.Occupied) 
                board.ocean[coords.Item1, coords.Item2].SquareStatus = SquareStatus.Hit;

            else if (board.ocean[coords.Item1, coords.Item2].SquareStatus == SquareStatus.Empty)
                board.ocean[coords.Item1, coords.Item2].SquareStatus = SquareStatus.Missed;
        }

        public void SinkShip()
        {
            foreach (var ship in Ships)
            {
                if (ship.SquareList.All(x => x.SquareStatus == SquareStatus.Sunk))
                {
                    Ships.Remove(ship);
                }
            }
        }
    }
}

    