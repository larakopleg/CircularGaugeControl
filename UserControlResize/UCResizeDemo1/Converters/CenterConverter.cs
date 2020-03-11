using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace UCResizeDemo1
{
    class CenterConverter : IMultiValueConverter
    {
        public object Convert(object[] value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((value.Length == 3) && (value[0] is double) && (value[1] is double) && value[2] is double)
            {
                double v1 = (double)value[0];
                double v2 = (double)value[1];
                double širinaKazaljke = (double)value[2];
                double size = Math.Min(v1, v2);
                return new Thickness(size / 2 - širinaKazaljke / 2, /*size*0.02/2*/ 0, 0, 0);
                
            }
            return 0;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


}
