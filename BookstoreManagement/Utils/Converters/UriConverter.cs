using System;
using System.Globalization;
using System.Windows.Data;

namespace BookstoreManagement.Utils.Converters {
	public class UriConverter : IValueConverter {
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
			if (!(value is string))
				return Binding.DoNothing;
			return new Uri(value as string);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
			throw new NotImplementedException();
		}
	}
}