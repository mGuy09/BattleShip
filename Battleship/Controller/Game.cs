using System.Runtime.InteropServices;
using Battleship.Misc;
using Battleship.Model;
using Battleship.View;

namespace Battleship.Controller
{
    public class Game
    {
        public int? Turns;
        public Board board1 = new Board();
        public Board board2 = new Board();
        public static Player player1 = new Player();
        public static Player player2 = new Player();
        public static Player currentPlayer = player2;
        public static AI ai = new AI();
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
                    PlacingPhase(player1);
                    PlacingPhase(player2);
                    break;
                case 2:
                    Display.Clear();
                    PlacingPhase(player1);
                    //PlacingPhase(ai);
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
                                    goto settingslabel;
                                case 2:
                                    Board.Size = 20;
                                    goto settingslabel;
                                case 3:
                                    Board.Size = 25;
                                    goto settingslabel;
                                case 4:
                                    goto settingslabel;
                                default:
                                    Display.ShowText(Errors.invalidInput);
                                    break;
                            }
                            break;
                        case 2:
                            Display.Clear();
                            Display.ShowText(MainMenu.turnsLimit);
                            switch (Input.GetInput())
                            {
                                case 1:
                                    Turns = 5;
                                    goto settingslabel;
                                case 2:
                                    Turns = 10;
                                    goto settingslabel;
                                case 3:
                                    Turns = null;
                                    goto settingslabel;
                                case 4:
                                    goto settingslabel;
                                default:
                                    Display.ShowText(Errors.invalidInput);
                                    break;
                            }
                            break;
                        case 3:
                            goto mainMenuLabel;
                        default:
                            Display.ShowText(Errors.invalidInput);
                            break;
                    }
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                case 5:
                    board1.CreateBoard();
                    Display.ShowBoard(board1.ToString(false));
                    break;
                default:
                    Display.ShowText(Errors.invalidInput);
                    break;
            }
        }

        public void PlacingPhase(Player currentPlayer)
        {
            board1.CreateBoard();
            board2.CreateBoard();
            Display.ShowText(currentPlayer == player1 ? Messages.PlacingPhase1: Messages.PlacingPhase2);
            Board currentBoard = currentPlayer == player1 ? board1 : board2;


            Display.ShowText(MainMenu.PlacingType);
            switch (Input.GetInput())
            {
                case 1:
                    BoardFactory.ManualPlacement(currentBoard, currentPlayer);
                    break;
                case 2:
                    BoardFactory.RandomPLacement(currentBoard, currentPlayer);
                    break;
                default:
                    Display.ShowText(Errors.invalidInput);
                    break;
            }
                //Display.ShowText(currentPlayer.ToString());
                //Display.ShowBoard(board1.ToString());
                
            
            
        }

        public void Round()
        {
            currentPlayer = currentPlayer == player1 ? currentPlayer = player2 : currentPlayer = player1;
            Board currentBoard = currentPlayer == player1 ? board2 : board1;
            Display.ShowBoard(currentBoard.ToString(true));
            Display.ShowText(currentPlayer == player1 ? Messages.ShootingPhase1:Messages.ShootingPhase2);
            currentPlayer.Shoot(currentBoard, Input.GetCoordinates(Board.Size));
            currentPlayer.SinkShip();
        }

        public bool IsWinning()
        {
            currentPlayer = currentPlayer == player1 ? player2 : player1;
            if (!currentPlayer.IsAlive)
            {
                return true;
            }
            return false;
            
        }
    }
}