using System;
using System.Globalization;
using System.Windows.Data;

namespace Clock.Views.Converters
{
    class MillisecondToAngleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => value is int ? (int)value * 0.36d : value;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => value is int ? (int)value / 0.36d : value;
    }
}
