using Cells;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class PlayScreenViewModel : ScreenViewModel
    {
        public GameViewModel GameVM { get; set; }

        public ICell<IGame> Game {
            get { 
                return GameVM.Game; 
            }
        }

        public GameBoardViewModel Board
        {
            get
            {
                return GameVM.Board;
            }
        }

        public PlayScreenViewModel(ICell<ScreenViewModel> currentScreen, int size, int difficulty, Boolean flooding) : base(currentScreen)
        {
            GameVM = new GameViewModel(size, difficulty, flooding);
            SwitchToSettingScreen = new ActionCommand(() => CurrentScreen.Value = new SettingScreenViewModel(this.CurrentScreen));
            TryAgain = new ActionCommand(() => CurrentScreen.Value = new PlayScreenViewModel(this.CurrentScreen, size, difficulty, flooding));
        }

        public ICommand SwitchToSettingScreen { get; }

        public ICommand TryAgain { get; }

    }
}
