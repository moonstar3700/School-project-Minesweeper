using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace View.Converters
{
    class SquareStatusConverter : IValueConverter
    {
        public Object Flagged { get; set; }
        public Object Mine { get; set; }
        public Object Covered { get; set; }
        public Object Uncovered { get; set; }
        public Object Zero { get; set; }
        public object Convert(Object value, Type targetType, object parameter, CultureInfo culture)
        {
            var square = (Square)value;
            var status = square.Status;
            switch (status)
            {
                case SquareStatus.Flagged: return Flagged;
                case SquareStatus.Mine: return Mine;
                case SquareStatus.Covered: return Covered;
                case SquareStatus.Uncovered:
                    if (square.NeighboringMineCount == 0)
                    {
                        return Zero;
                    }
                    else
                    {
                        return Uncovered;
                        
                    }
                    
                default: throw new ArgumentNullException("invalid State");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }



    }
}