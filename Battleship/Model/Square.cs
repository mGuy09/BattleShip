using System.Reflection.Emit;

namespace Battleship.Model
{
    public class Square
    {
        public (int, int) Position { get; set; }
        public SquareStatus SquareStatus;

        public string ShowSquareStatus(SquareStatus status)
        {
            return status.ToString();
        }
    }
}

