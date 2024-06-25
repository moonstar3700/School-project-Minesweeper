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
    public class NumberColorConverter : IValueConverter
    {
        public object Zero { get; set; }
        public object One { get; set; }
        public object Two { get; set; }
        public object Three { get; set; }
        public object Four { get; set; }
        public object Five { get; set; }
        public object More { get; set; }
        


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var square = (Square)value;
            var mines = square.NeighboringMineCount;
            switch (mines)
            {
                case 0:
                    return Zero;
                case 1:
                    return One;
                case 2:
                    return Two;
                case 3:
                    return Three;
                case 4:
                    return Four;
                case 5:
                    return Five;
                case 6:
                case 7:
                case 8:
                case 9:
                    return More;

                default:
                    throw new ArgumentNullException("invalid number");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
