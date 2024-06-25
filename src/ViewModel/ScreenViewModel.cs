using Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public abstract class ScreenViewModel
    {
        protected ScreenViewModel(ICell<ScreenViewModel> currentScreen)
        {
            this.CurrentScreen = currentScreen;
        }

        protected ICell<ScreenViewModel> CurrentScreen { get; }
    }
}
