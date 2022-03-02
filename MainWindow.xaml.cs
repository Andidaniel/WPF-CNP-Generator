using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Converters_example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResultTBlock.Visibility = Visibility.Hidden;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultTBlock.Visibility = Visibility.Visible;
            if (ResultTBlock.Text != "Please fill in all the fields")
            {
                GenderCBox.IsEditable = false;
                GenderCBox.IsHitTestVisible = false;
                GenderCBox.Focusable = false;
                CountyCBox.IsEditable = false;
                CountyCBox.IsHitTestVisible = false;
                CountyCBox.Focusable = false;
                BDayPicker.Focusable = false;
                BDayPicker.IsHitTestVisible = false;
                
            }

        }
    }
}
