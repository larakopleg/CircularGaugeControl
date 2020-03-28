using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UCResizeDemo1
{
    /// <summary>
    /// Interaction logic for SizableControl.xaml
    /// </summary>
    public partial class SizableControl : UserControl, INotifyPropertyChanged
    {
        
        public static readonly DependencyProperty KazaljkaWidthProperty = DependencyProperty.Register(
              "KazaljkaWidth",
              typeof(double),
              typeof(SizableControl),
              new UIPropertyMetadata(2.0)
        );

        public double KazaljkaWidth
        {
            get { return (double)GetValue(KazaljkaWidthProperty); }
            set { SetValue(KazaljkaWidthProperty, value); }
        }

        public static readonly DependencyProperty StartingAngleProperty = DependencyProperty.Register(
              "StartingAngle",
              typeof(double),
              typeof(SizableControl),
              new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender, new PropertyChangedCallback(OnStartingAngleChanged)));

        private static void OnStartingAngleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SizableControl control = (SizableControl)d;
            control.NotifyPropertyChanged("StartingAngle");
        }

        public double StartingAngle
        {
            get { return (double)GetValue(StartingAngleProperty); }
            set { SetValue(StartingAngleProperty, value); }
        }

        public static readonly DependencyProperty EndingAngleProperty = DependencyProperty.Register(
              "EndingAngle",
              typeof(double),
              typeof(SizableControl),
              new FrameworkPropertyMetadata(360.0, FrameworkPropertyMetadataOptions.AffectsRender, new PropertyChangedCallback(OnEndingAngleChanged)));

        private static void OnEndingAngleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SizableControl control = (SizableControl)d;
            control.NotifyPropertyChanged("EndingAngle");
        }

        public double EndingAngle
        {
            get { return (double)GetValue(EndingAngleProperty); }
            set { SetValue(EndingAngleProperty, value); }
        }
        
        public static readonly DependencyProperty MinValueProperty = DependencyProperty.Register(
              "MinValue",
              typeof(double),
              typeof(SizableControl),
              new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender, new PropertyChangedCallback(OnMinValueChanged)));

        private static void OnMinValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SizableControl control = (SizableControl)d;
            control.NotifyPropertyChanged("MinValue");
        }

        public double MinValue
        {
            get { return (double)GetValue(MinValueProperty); }
            set { SetValue(MinValueProperty, value); }
        }
        
        public static readonly DependencyProperty MaxValueProperty = DependencyProperty.Register(
              "MaxValue",
              typeof(double),
              typeof(SizableControl),
              new FrameworkPropertyMetadata(360.0, FrameworkPropertyMetadataOptions.AffectsRender, new PropertyChangedCallback(OnMaxValueChanged)));

        private static void OnMaxValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SizableControl control = (SizableControl)d;
            control.NotifyPropertyChanged("MaxValue");
        }

        public double MaxValue
        {
            get { return (double)GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }
        

        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set{ SetValue(ValueProperty, value); }
        }


        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(SizableControl), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender, new PropertyChangedCallback(OnValueChanged)));

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SizableControl control = (SizableControl)d;
            control.Value = (double)e.NewValue;
            Console.WriteLine(control.Value);
        }
        

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        
        public SizableControl()
        {
            
            InitializeComponent();
            
        }
    }
}
