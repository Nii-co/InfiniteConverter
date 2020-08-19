using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace InfiniteConverter
{
    public class NiceConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string resultAfterConvert = value as string + "S";
            Console.WriteLine("value:"+ resultAfterConvert);
            return resultAfterConvert;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string resultAfterConvert = value as string + "T";
            Console.WriteLine("value:" + resultAfterConvert);
            return resultAfterConvert;
        }
    }
}
