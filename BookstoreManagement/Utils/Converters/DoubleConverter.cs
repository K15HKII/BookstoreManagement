using System;
using System.Windows.Data;
using BookstoreManagement.Annotations;

namespace BookstoreManagement.Utils.Converters;

[ValueConversion(typeof(string), typeof(double))]
[PublicAPI]
public class DoubleConverter : IValueConverter
{
    
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is string str)
        {
            double result;
            if (double.TryParse(str, out result))
            {
                return result;
            }
        }
        return 0;
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is double)
            return value;
        return "";
    }
    
}