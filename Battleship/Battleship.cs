using Battleship.Controller;


namespace Battleship
{
    public class Battleship
    {

        public static void Main()
        {
            
            bool isGameon = true;
            Game game = new Game();
            game.Start();
            while (isGameon)
            {
                game.Round();
                if (game.IsWinning())
                {
                    isGameon = false;
                }
            }



        }
    }
} 