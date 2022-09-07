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

        
    }
}
