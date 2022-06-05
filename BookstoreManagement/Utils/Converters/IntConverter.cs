using System;
using System.Windows.Data;
using BookstoreManagement.Annotations;

namespace BookstoreManagement.Utils.Converters;

[ValueConversion(typeof(string), typeof(int))]
[PublicAPI]
public class IntConverter : IValueConverter
{
    
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is string str)
        {
            int result;
            if (int.TryParse(str, out result))
            {
                return result;
            }
        }
        return 0;
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is int)
            return value;
        return "";
    }
    
}