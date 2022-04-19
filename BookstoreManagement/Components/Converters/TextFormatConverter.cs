using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BookstoreManagement.Components.Converters
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
            throw new InvalidOperationException();
        }

    }
}
