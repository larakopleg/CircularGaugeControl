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
              new FrameworkPropertyMetadata(2.0,
                  FrameworkPropertyMetadataOptions.AffectsRender,
                  new PropertyChangedCallback(OnKazaljkaWidthChanged),
                  new CoerceValueCallback(CoerceKazaljkaWidth)
            )
        );

        public double KazaljkaWidth
        {
            get { return (double)GetValue(KazaljkaWidthProperty); }
            set { SetValue(KazaljkaWidthProperty, value); }
        }


        private static void OnKazaljkaWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Pročitati odavde: https://docs.microsoft.com/en-us/dotnet/framework/wpf/advanced/dependency-property-callbacks-and-validation

            //d.CoerceValue(MinReadingProperty);
            //d.CoerceValue(MaxReadingProperty);
        }


        private static object CoerceKazaljkaWidth(DependencyObject d, object value)
        {
            SizableControl g = (SizableControl)d;
            double current = (double)value;
            if (current < 1) current = 1;
            if (current > 25) current = 25;
            return current;
        }


        public static readonly DependencyProperty StartingAngleProperty = DependencyProperty.Register(
              "StartingAngle",
              typeof(double),
              typeof(SizableControl),
              new FrameworkPropertyMetadata(2.0,
                  FrameworkPropertyMetadataOptions.AffectsRender,
                  new PropertyChangedCallback(OnStartingAngleChanged),
                  new CoerceValueCallback(CoerceStartingAngle)
            )
);
        
        public double StartingAngle
        {
            get { return (double)GetValue(StartingAngleProperty); }
            set { SetValue(StartingAngleProperty, value); }
        }

        
        private static void OnStartingAngleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Pročitati odavde: https://docs.microsoft.com/en-us/dotnet/framework/wpf/advanced/dependency-property-callbacks-and-validation

            

            //d.CoerceValue(MinReadingProperty);
            //d.CoerceValue(MaxReadingProperty);
        }


        private static object CoerceStartingAngle(DependencyObject d, object value)
        {
            SizableControl g = (SizableControl)d;
            double current = (double)value;
            return current;
        }

        public static readonly DependencyProperty EndingAngleProperty = DependencyProperty.Register(
              "EndingAngle",
              typeof(double),
              typeof(SizableControl),
              new FrameworkPropertyMetadata(2.0,
                  FrameworkPropertyMetadataOptions.AffectsRender,
                  new PropertyChangedCallback(OnEndingAngleChanged),
                  new CoerceValueCallback(CoerceEndingAngle)
            )
);

        public double EndingAngle
        {
            get { return (double)GetValue(EndingAngleProperty); }
            set { SetValue(EndingAngleProperty, value); }
        }

        private static void OnEndingAngleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Pročitati odavde: https://docs.microsoft.com/en-us/dotnet/framework/wpf/advanced/dependency-property-callbacks-and-validation

            //d.CoerceValue(MinReadingProperty);
            //d.CoerceValue(MaxReadingProperty);
        }


        private static object CoerceEndingAngle(DependencyObject d, object value)
        {
            SizableControl g = (SizableControl)d;
            double current = (double)value;
            return current;
        }


        public static readonly DependencyProperty MinValueProperty = DependencyProperty.Register(
              "MinValue",
              typeof(double),
              typeof(SizableControl),
              new FrameworkPropertyMetadata(2.0,
                  FrameworkPropertyMetadataOptions.AffectsRender,
                  new PropertyChangedCallback(OnMinValueChanged),
                  new CoerceValueCallback(CoerceMinValue)
            )
        );

        public double MinValue
        {
            get { return (double)GetValue(MinValueProperty); }
            set { SetValue(MinValueProperty, value); }
        }


        private static void OnMinValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Pročitati odavde: https://docs.microsoft.com/en-us/dotnet/framework/wpf/advanced/dependency-property-callbacks-and-validation

            //d.CoerceValue(MinReadingProperty);
            //d.CoerceValue(MaxReadingProperty);
        }


        private static object CoerceMinValue(DependencyObject d, object value)
        {
            SizableControl g = (SizableControl)d;
            double current = (double)value;
            if (current < 1) current = 1;
            if (current > 25) current = 25;
            return current;
        }


        public static readonly DependencyProperty MaxValueProperty = DependencyProperty.Register(
              "MaxValue",
              typeof(double),
              typeof(SizableControl),
              new FrameworkPropertyMetadata(2.0,
                  FrameworkPropertyMetadataOptions.AffectsRender,
                  new PropertyChangedCallback(OnMaxValueChanged),
                  new CoerceValueCallback(CoerceMaxValue)
            )
        );

        public double MaxValue
        {
            get { return (double)GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }


        private static void OnMaxValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Pročitati odavde: https://docs.microsoft.com/en-us/dotnet/framework/wpf/advanced/dependency-property-callbacks-and-validation

            //d.CoerceValue(MinReadingProperty);
            //d.CoerceValue(MaxReadingProperty);
        }


        private static object CoerceMaxValue(DependencyObject d, object value)
        {
            SizableControl g = (SizableControl)d;
            double current = (double)value;
            if (current < 1) current = 1;
            if (current > 25) current = 25;
            return current;
        }

        public SizableControl()
        {
            InitializeComponent();
        }
        
        //private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        //{
        //}
    }
}
