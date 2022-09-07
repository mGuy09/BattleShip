using Battleship.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.View
{
    public class Display
    {
        public static void Clear()
        {
            Console.Clear();
        }

        public static void ShowText(string text)
        {
            Console.WriteLine(text);
        }

        public static void ShowBoard(Board board)
        {
            ShowText(board.ToString());

        }
        

        }
}
