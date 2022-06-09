using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using BookstoreManagement.Services;

namespace BookstoreManagement.Utils.Converters;

public class UriImageConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string uriStr)
        {
            var uri = new Uri(ServiceConfig.BASE_URL + "/images/" + uriStr + ".png");
            var bitmap = new BitmapImage(uri);
            return bitmap;
        }
        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}