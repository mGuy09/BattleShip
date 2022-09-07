using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Battleship.View
{
    internal class Input
    {
        public static int GetInput()
        {
            int option = 0;
        chooseOption:
            string? input = Console.ReadLine();
            if (input != null && Regex.IsMatch(input, @"^\d+$"))
            {
               option = int.Parse(input);
               
            }
            else goto chooseOption;
            return option;

        }

        public static (int, int) GetCoordinates(int size)
        {
            (int, int) option = (0, 0);
            chooseOption:
            string input = Console.ReadLine();
            option.Item1 = int.Parse(input[0].ToString()) - 97;
            option.Item2 = int.Parse(input[1].ToString()) - 1;
            if (option.Item1 < size && option.Item2 < size) return option;
            goto chooseOption;

        }

    }
}
