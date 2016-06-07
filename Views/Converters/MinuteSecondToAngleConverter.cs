using System;
using System.Globalization;
using System.Windows.Data;

namespace Clock
{
    public class MinuteSecondToAngleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is int))
                return value;

            return (int)value * 6;            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is int))
                return value;

            return (int)value / 6;
        }
    }
}
