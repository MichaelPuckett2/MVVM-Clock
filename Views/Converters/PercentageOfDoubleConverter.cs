using System;
using System.Globalization;
using System.Windows.Data;

namespace Clock.Views.Converters
{
    public class PercentageOfDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is double))
                return value;

            double percent;

            if (!double.TryParse(parameter.ToString(), out percent))
                return value;

            percent = percent / 100;

            return (double)value * percent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
