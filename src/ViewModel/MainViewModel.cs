using Cells;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            CurrentScreen = Cell.Create<ScreenViewModel>(null);
            CurrentScreen.Value = new SettingScreenViewModel(CurrentScreen);
        }

        public ICell<ScreenViewModel> CurrentScreen { get; }
    }
}
