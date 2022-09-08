using System.Runtime.CompilerServices;
using System.Text;

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

        public Square[,] CreateBoard()
        {
            Square[,] ocean = new Square[Size,Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    ocean[i, j] = new Square();
                    ocean[i, j].Position = (i, j);
                }
            }

            return ocean;
        }

        public string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(" ");
            for (int i = 1; i <= Size; i++)
            {
                if (i < 10)
                {
                    sb.Append($"  {i}");
                }
                else
                {
                    sb.Append($" {i}");
                }
                
            }

            sb.Append("\n");

            for (char x = 'A'; x - 'A' < Size; x++)
            {
                sb.Append($"{x}");
                for (int i = 0; i < Size; i++)
                {
                    if (ocean[x-97, i].SquareStatus == SquareStatus.Empty) sb.Append("  .");
                    else if (ocean[x - 97, i].SquareStatus == SquareStatus.Occupied) sb.Append("  █");
                    else if (ocean[x - 97, i].SquareStatus == SquareStatus.Hit) sb.Append("  █");
                    else if (ocean[x - 97, i].SquareStatus == SquareStatus.Missed) sb.Append("  █");
                    else if (ocean[x - 97, i].SquareStatus == SquareStatus.Sunk) sb.Append("  █");
                    
                }
                sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}
    


