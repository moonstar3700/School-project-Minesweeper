using Cells;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class GameBoardViewModel
    {
        public readonly ICell<IGameBoard> board;
        public IEnumerable<RowViewModel> rows;

        public ICell<IGameBoard> Board
        {
            get
            {
                return board;
            }
        }
        public IEnumerable<RowViewModel> Rows
        {
            get
            {
                return rows;
            }
        }

        public GameBoardViewModel(ICell<IGame> game)
        {
            this.rows = getRows(game);
            this.board = game.Derive(g => g.Board);
        }


        private RowViewModel Row(ICell<IGame> game, int row)
        {
            return new RowViewModel(game, row);
        }
        private IEnumerable<RowViewModel> getRows(ICell<IGame> game)
        {

            List<RowViewModel> rows = new List<RowViewModel>();
            for (int i = 0; i < game.Value.Board.Height; i++)
            {
                RowViewModel row = Row(game, i);
                rows.Add(row);
            }
            return rows;
        }
    }
}
