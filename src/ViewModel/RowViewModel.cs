using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class RowViewModel
    {
        private readonly IEnumerable<SquareViewModel> squares;

        public IEnumerable<SquareViewModel> Squares
        {
            get
            {
                return this.squares;
            }
        }
        public RowViewModel(ICell<IGame> game, int row)
        {
            this.squares = FormatSquares(game, row);
        }
        public IEnumerable<SquareViewModel> FormatSquares(ICell<IGame> game, int row)
        {
            List<SquareViewModel> newsquares = new List<SquareViewModel>();
            for (int i = 0; i < game.Value.Board[row].Count(); i++)
            {
                newsquares.Add(new SquareViewModel(game, new Vector2D(i, row)));
            }
            return newsquares;
        }
    }
}
