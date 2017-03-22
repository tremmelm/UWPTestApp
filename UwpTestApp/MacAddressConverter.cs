using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UwpTestApp
{
    public class MacAddressConverter : Windows.UI.Xaml.Data.IValueConverter
    {
        private const char MacAdressSegmentsSeparator = '-';
        private const string ArgumentNullErrorMessage = "index is not specified";
        public string _macAddress = string.Empty;

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            _macAddress = value?.ToString();

            int index;
            if(int.TryParse(parameter?.ToString(), out index))
            {
                return _macAddress?.Split(MacAdressSegmentsSeparator)?.GetValue(index);
            }

            throw new ArgumentNullException("parameter", ArgumentNullErrorMessage);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            var segments = _macAddress.Split(MacAdressSegmentsSeparator);

            int index;
            if (int.TryParse(parameter?.ToString(), out index))
            {
                segments[index] = value?.ToString();
                return string.Join(MacAdressSegmentsSeparator.ToString(), segments);
            }

            throw new ArgumentNullException("parameter", ArgumentNullErrorMessage);
        }

    }

}
