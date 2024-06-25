using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    internal class MineSweepGame
    {
        private IGame value;
        public MineSweepGame(IGame value)
        {
            this.value = value;
        }
    }
}
