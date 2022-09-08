using System;
using System.Text.RegularExpressions;

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
            string input = Console.ReadLine().ToUpper();
            
            option.Item1 = input[0] - 65;
            option.Item2 = int.Parse(input[1].ToString()) - 1;
            if (option.Item1 < size && option.Item2 < size) return option;
            goto chooseOption;

        }

    }
}
