using System.Globalization;

namespace Battleship.Model
{
    public class Board
    {
        public static int Size { get; set; } = 15;

        public Square[,] ocean;

        public bool IsPlacementOk()
        {
            return false;
        }

        public void CreateBoard()
        {
            
        }
    }
}
    


