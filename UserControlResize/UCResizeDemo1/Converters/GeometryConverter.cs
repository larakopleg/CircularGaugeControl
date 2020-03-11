using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace UCResizeDemo1
{
    class GeometryConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if ((values.Length == 4) && (values[0] is double) && (values[1] is double) && (values[2] is double) && (values[3] is double))
            {
                //foreach(object v in values)
                //{
                //    Console.WriteLine((double)v);
                //}

                double w = (double)values[0];
                double h = (double)values[1];
                double startingAngle = (double)values[2];
                double endingAngle = (double)values[3];

                double radius = Math.Min(w, h) / 2;

                Slice slice = new Slice();
                PathGeometry geom = slice.makeIsecak(new Point(radius,radius), startingAngle, endingAngle);
                
                return geom;

            }
            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
