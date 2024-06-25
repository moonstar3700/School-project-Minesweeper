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
    class FlagSquareCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private ICell<IGame> game;
        private Vector2D positon;

        public FlagSquareCommand(ICell<IGame> game, Vector2D positon)

        {
            this.game = game;
            this.positon = positon;
        }
        public bool CanExecute(object parameter)
        {
            return game.Value.IsSquareCovered(new Vector2D(positon.X, positon.Y)) && game.Value.Status == GameStatus.InProgress;
        }

        public void Execute(object parameter)
        {
            game.Value = game.Value.ToggleFlag(new Vector2D(positon.X, positon.Y));
        }
    }
}
