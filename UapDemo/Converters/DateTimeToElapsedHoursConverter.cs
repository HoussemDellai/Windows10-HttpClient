using System;
using Windows.UI.Xaml.Data;

namespace UapDemo.Converters
{
    public class DateTimeToElapsedHoursConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var dateTime = (DateTime)value;

            var elapsedHours = (DateTime.UtcNow - dateTime).Hours;

            return elapsedHours + " hours ago";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
