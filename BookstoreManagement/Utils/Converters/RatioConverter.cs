using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using static BookstoreManagement.Utils.NumberUtils;

namespace BookstoreManagement.Utils.Converters {
    public class RatioConverter : MarkupExtension, IValueConverter {
        private static RatioConverter _instance;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Console.WriteLine(value + " : " + parameter);
            double ratio = GetDouble(parameter.ToString());
            int intSource;
            if (int.TryParse(value.ToString(), out intSource))
            {
                intSource = (int) (intSource * ratio);
                Console.WriteLine(intSource + " - " + ratio);
                return intSource;
            }
            double doubleSource = GetDouble(value.ToString());
            return doubleSource * ratio;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider) => _instance ??= new RatioConverter();
    }
}
