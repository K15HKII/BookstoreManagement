using System;
using System.Globalization;
using System.Windows.Data;
using MaterialDesignThemes.Wpf;

namespace BookstoreManagement.Components
{
    public class TextFormatConverter : IValueConverter
    {

        private string _format;

        public string Format
        {
            get => _format;
            set => _format = value;
        }

        // IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            value = value ?? "null";
            return string.Format(culture ?? CultureInfo.CurrentCulture, _format ?? "{0}", value.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            PackIcon thickness;
            throw new InvalidOperationException();
        }

    }
}
