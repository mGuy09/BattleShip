using Battleship.Misc;
using Battleship.View;

namespace Battleship.Controller
{
    public class Game
    {
        public int Size = 15;
        public int? Turns = null;


        public void Start()
        {
        mainMenuLabel:
            Display.ShowText(Messages.Welcome);
            Display.ShowText(MainMenu.menu);
            int option = Input.GetInput();
            switch (option)
            {
                case 1:
                    Display.Clear();
                    break;
                case 2:
                    Display.Clear();
                    break;
                case 3:
                settingslabel:
                    Display.Clear();
                    Display.ShowText(MainMenu.settings);
                    switch (Input.GetInput())
                    {
                        case 1:
                            Display.Clear();
                            Display.ShowText(MainMenu.mapSize);
                            switch (Input.GetInput())
                            {
                                case 1:
                                    Size = 15;
                                    break;
                                case 2:
                                    Size = 20;
                                    break;
                                case 3:
                                    Size = 25;
                                    break;
                                case 4:
                                    goto settingslabel;
                            }
                            break;
                        case 2:
                            Display.Clear();
                            Display.ShowText(MainMenu.turnsLimit);
                            switch (Input.GetInput())
                            {
                                case 1:
                                    Turns = 5;
                                    break;
                                case 2:
                                    Turns = 10;
                                    break;
                                case 3:
                                    Turns = null;
                                    break;
                                case 4:
                                    goto settingslabel;

                            }

                            break;
                        case 3:
                            goto mainMenuLabel;
                    }
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }

    }
}