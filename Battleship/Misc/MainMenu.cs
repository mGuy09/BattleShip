using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battleship.View;

namespace Battleship.Misc
{
    internal class MainMenu
    {
        public const string menu = @"1. Player vs Player
            2. Player vs Computer
            3. Game Settings
            4. Exit";

        public const string settings = @"1. Map size
            2. Turns limit
            3. Back";

        public const string mapSize = @" 1. 10 x 10
            2. 15 x 15
            3. 20 x 20
            4. Back";

        public const string turnsLimit = @" 1. 5 turns
            2. 10 turns
            3. Unlimited
            4. Back";
    }
}
