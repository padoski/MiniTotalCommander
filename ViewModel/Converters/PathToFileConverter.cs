using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;

namespace Commander.ViewModel.Converters
{


    [ValueConversion(typeof(string), typeof(string))]
    public class PathToFileConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return string.Empty;
            }
            else
            {
                return Path.GetFileName(value.ToString());
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }


    }
}
