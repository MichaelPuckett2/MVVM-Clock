﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Clock.Views.Converters
{
    public class MinuteSecondToAngleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => value is int ? (int)value * 6 : value;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => value is int ? (int)value / 6 : value;
    }
}
