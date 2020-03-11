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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Thickness originalMargin;

        public MainWindow()
        {
            ValueAngle va = new ValueAngle(-50, 150, 1, 10);
            this.DataContext = va;
            InitializeComponent();
            originalMargin = sizableControl.Margin;
        }
        

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.PreviousSize.Height != 0 && e.PreviousSize.Width != 0)
            {
                double originalHeight = e.PreviousSize.Height;
                double originalWidth = e.PreviousSize.Width;
                double newHeight = ActualHeight;
                double newWidth = ActualWidth;

                double percentH = newHeight / originalHeight;
                double percentW = newWidth / originalWidth;

                double controlHeight = sizableControl.Height;
                double controlWidth = sizableControl.Width;
                //Console.WriteLine("originalH=" + originalHeight + " originalW=" + originalWidth + " newvisina=" + newHeight + " newsirina=" + newWidth + " percentH=" + percentH + " percentW=" + percentW);

                sizableControl.Height = controlHeight * percentH;
                sizableControl.Width = controlWidth * percentW;

                double percentMarginLeft = Math.Min(percentH, percentW);
                Thickness newMargin = new Thickness();

                //newMargin.Bottom = originalMargin.Bottom * percentM;
                newMargin.Left = originalMargin.Left * percentW;
                //newMargin.Right = originalMargin.Right * percentM;
                newMargin.Top = originalMargin.Top * percentH;


                sizableControl.Margin = newMargin;
                originalMargin = newMargin;
                //Console.WriteLine("leva=" + newMargin.Left + " gornja=" + newMargin.Top);
            }
        }
    }
}
