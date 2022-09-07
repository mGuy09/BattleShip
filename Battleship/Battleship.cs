using Battleship.Controller;
using Battleship.Misc;
using Battleship.View;

namespace Battleship
{
    public class Battleship
    {

        public void Main()
        {
            bool isGameon = true;
            Game game = new Game();
            Display.ShowText(Messages.Welcome);
            Display.ShowText(MainMenu.menu);

        }
    }
} 