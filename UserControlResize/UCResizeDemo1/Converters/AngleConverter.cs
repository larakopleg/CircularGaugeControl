using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace UCResizeDemo1
{
    class AngleConverter : IMultiValueConverter
    {
        private double podeok;
        private double addAngle;
        private double angle;
        private double start;
        private double end;
        private double min;
        private double max;
        private double valueSC;

        public object Convert(object[] value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.Length == 5)
            {
                start = (double)value[0];
                end = (double)value[1];
                min = (double)value[2];
                max = (double)value[3];
                valueSC = (double)value[4];

                addAngleAndSetPodeok(start, end, min, max);

                double calculatedAngle = calculateAngle();

                return calculatedAngle + 90;
            }
            return 0;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private void addAngleAndSetPodeok(double start, double end, double min, double max)
        {
            if (start > 180)
            {
                addAngle = end - 360;
                angle = end - 360;
                podeok = -(end - start) / (max - min);
            }
            else
            {
                addAngle = start;
                angle = start;
                podeok = (end - start) / (max - min);
            }
        }

        private double calculateAngle()
        {
            if (valueSC >= min && valueSC <= max)
            {
                if (min < 0)
                {
                    return (valueSC + Math.Abs(min)) * podeok + addAngle;
                    
                }
                else
                {
                    return (valueSC - Math.Abs(min)) * podeok + addAngle;
                    
                }
            }
            return 0;
        }
    }
}
