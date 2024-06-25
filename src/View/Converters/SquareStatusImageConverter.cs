using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace View.Converters
{
    public class SquareStatusImageConverter : IValueConverter
    {
        public SquareStatus squareStatus;

        public Object Flagged { get;  set; }
        public Object Covered { get;  set; }
        public Object Uncovered { get;  set; }
        public Object Mine { get;  set; }

        public Object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            squareStatus = (SquareStatus)value;
            return squareStatus switch
            {
                SquareStatus.Flagged => Flagged,
                SquareStatus.Covered => Covered,
                SquareStatus.Uncovered => Uncovered,
                SquareStatus.Mine => Mine,
                _ => throw new ArgumentException()
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
