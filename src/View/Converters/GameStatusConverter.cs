﻿using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace View.Converters
{
    internal class GameStatusConverter : IValueConverter
    {

        public object Lost { get; set; }
        public object Won { get; set; }
        public object InProgress { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var gameStatus = (GameStatus)value;
            switch (gameStatus)
            {
                case GameStatus.Lost:
                    return Lost;
                case GameStatus.Won:
                    return Won;
                case GameStatus.InProgress:
                    return InProgress;


                default:
                    throw new Exception();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
