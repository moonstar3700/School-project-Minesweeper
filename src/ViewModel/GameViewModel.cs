using Cells;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class GameViewModel
    {

        public GameBoardViewModel Board
        {
            get
            {
                return new GameBoardViewModel(Game);
            }
        }
        public ICell<IGame> Game
        {
            get;
            set;
        }

        public void gameOverCheck()
        {
            ICell<IGame> ThisGame = Game;
        }

        private double fixDificulty(double difficulty)
        {
            return difficulty / 100;
        }

        public GameViewModel( int size, int difficulty, Boolean flooding)   
        {
            Game = Cell.Create(IGame.CreateRandom(size, fixDificulty(difficulty), flooding));  
        }

    }
}
