using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCResizeDemo1
{
    class ValueAngle : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        private double tAngle;
        private double sAngle;
        private double minValue;
        private double maxValue;
        private double podeok;
        private double addAngle;

        public ValueAngle(double startAngle, double terminalAngle, double minValue, double maxValue)
        {
            //_angle = startAngle;
            _value = minValue;

            this.tAngle = terminalAngle;
            this.sAngle = startAngle;

            if (startAngle > 180)
            {
                addAngle = terminalAngle - 360;
                _angle = terminalAngle - 360;
                this.podeok = -(tAngle - sAngle) / (maxValue - minValue);
            }
            else
            {
                addAngle = startAngle;
                _angle = startAngle;
                this.podeok = (tAngle - sAngle) / (maxValue - minValue);
            }

            
           
            //this.minValue = 0;
            //this.maxValue = Math.Abs(terminalAngle - startAngle);
            this.minValue = minValue;
            this.maxValue = maxValue;
            
    }

        public double SAngle
        {
            get { return sAngle; }
        }

        public double TAngle
        {
            get { return tAngle; }
        }

        public double MinValue
        {
            get { return minValue; }
        }

        public double MaxValue
        {
            get { return maxValue; }
        }

        private double _angle;

        public double Angle
        {
            get { return _angle; }
            private set
            {
                _angle = value;
                NotifyPropertyChanged("Angle");
            }
        }

        

        private double _value;

        public double Value
        {
            get { return _value; }
            set
            {
                if (value >= minValue && value <= maxValue)
                {
                    //_value = Math.Round(value, 2);

                    _value = value;
                    
                    if (minValue < 0)
                    {
                        Angle = (value + Math.Abs(minValue)) * podeok + addAngle;
                    }
                    else
                    {
                        Angle = (value - Math.Abs(minValue)) * podeok + addAngle;
                    }
                    
                    

                    NotifyPropertyChanged("Value");
                }
            }
        }


    }
}
