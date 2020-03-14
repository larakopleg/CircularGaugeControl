using System;
using System.Collections.Generic;
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
    public partial class SizableControl : UserControl
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
              new UIPropertyMetadata(0.0));
        
        public double StartingAngle
        {
            get { return (double)GetValue(StartingAngleProperty); }
            set { SetValue(StartingAngleProperty, value); }
        }

        public static readonly DependencyProperty EndingAngleProperty = DependencyProperty.Register(
              "EndingAngle",
              typeof(double),
              typeof(SizableControl),
              new UIPropertyMetadata(0.0));

        public double EndingAngle
        {
            get { return (double)GetValue(EndingAngleProperty); }
            set { SetValue(EndingAngleProperty, value); }
        }
        
        public static readonly DependencyProperty MinValueProperty = DependencyProperty.Register(
              "MinValue",
              typeof(double),
              typeof(SizableControl),
              new UIPropertyMetadata(0.0));

        public double MinValue
        {
            get { return (double)GetValue(MinValueProperty); }
            set { SetValue(MinValueProperty, value); }
        }
        
        public static readonly DependencyProperty MaxValueProperty = DependencyProperty.Register(
              "MaxValue",
              typeof(double),
              typeof(SizableControl),
              new UIPropertyMetadata(360.0));

        public double MaxValue
        {
            get { return (double)GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }
        
        public SizableControl()
        {
            InitializeComponent();
        }
    }
}
