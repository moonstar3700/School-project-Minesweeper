using Cells;
using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.MineSweeper;
using System.Windows.Input;

namespace ViewModel
{
    public class SettingScreenViewModel : ScreenViewModel
    {
        public int MinBoardSize {
            get
            {
                return IGame.MinimumBoardSize;
            }
        }

        public int MaxBoardSize {
            get
            {
                return IGame.MaximumBoardSize;
            } 
        }

        public int MinProbablity { get; } = 1;

        public int MaxProbablity { get; } = 100;

        public ICell<int> MineProbability {
            get; set; }

        public ICell<int> BoardSize { get; set ;}


        public bool Flooding { get; set; }
        public SettingScreenViewModel(ICell<ScreenViewModel> currentScreen) : base(currentScreen)
        {
            BoardSize = Cell.Create(MinBoardSize);
            MineProbability = Cell.Create(50);
            SwitchToPlayScreen = new ActionCommand(() => CurrentScreen.Value = new PlayScreenViewModel(this.CurrentScreen, BoardSize.Value, MineProbability.Value, Flooding));
            EasyGame = new ActionCommand(() => CurrentScreen.Value = new PlayScreenViewModel(this.CurrentScreen, 9, 15, true));
            MediumGame = new ActionCommand(() => CurrentScreen.Value = new PlayScreenViewModel(this.CurrentScreen, 14, 25, true));
            HardGame = new ActionCommand(() => CurrentScreen.Value = new PlayScreenViewModel(this.CurrentScreen, 20, 35, true));
        }
        public ICommand SwitchToPlayScreen { get; }
        public ICommand EasyGame { get; }
        public ICommand MediumGame { get; }
        public ICommand HardGame { get; }


    }
}
