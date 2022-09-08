using Battleship.Controller;
using Battleship.Misc;
using Battleship.View;
using System;

namespace Battleship
{
    public class Battleship
    {

        public static void Main()
        {
            
            bool isGameon = true;
            Game game = new Game();
            game.Start();
            game.Round();
            

        }
    }
} 