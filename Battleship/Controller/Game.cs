﻿using Battleship.Misc;
using Battleship.Model;
using Battleship.View;

namespace Battleship.Controller
{
    public class Game
    {
        public int? Turns = null;
        public Board board1 = new Board();
        public Board board2 = new Board();
        

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
                                    Board.Size = 15;
                                    break;
                                case 2:
                                    Board.Size = 20;
                                    break;
                                case 3:
                                    Board.Size = 25;
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