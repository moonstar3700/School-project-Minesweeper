using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class SquareViewModel
    {
        private readonly ICell<Square> square;
        private readonly ICommand uncover;
        private readonly ICommand flag;
        private ICell<IGame> game;

        public ICell<Square> Square
        {
            get
            {
                return square;
            }

        }
        public ICell<SquareStatus> IOSstatus { get; set; }

        public ICommand Uncover
        {
            get
            {

                return this.uncover;

            }
        }
        public ICommand Flag
        {
            get
            {
                return this.flag;
            }
        }

        public SquareViewModel(ICell<IGame> game, Vector2D position)
        {
            this.IOSstatus = game.Derive(g =>
            {
                if (g.Status == GameStatus.Lost)
                {
                    if (g.Mines.Contains(position))
                    {
                        return (SquareStatus.Mine);
                    }
                }
                return (g.Board[position].Status);
            });

            this.square = game.Derive(g => g.Board[position]);
            this.uncover = new UncoverSquareCommand(game, position, this);
            this.flag = new FlagSquareCommand(game, position);
            this.game = game;
        }
    }
}
