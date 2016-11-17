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

namespace NorkAssignment8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, RoutedEventArgs e)
        {
            Mileage m = new NorkAssignment8.Mileage();
            m.Miles = double.Parse(textBoxMiles.Text);
            m.Gallons = double.Parse(textBoxGallons.Text);

            int tank;
            if(radioButton10.IsChecked == true)
            {
                tank = 10;
            }else if(radioButton15.IsChecked == true)
            {
                tank = 15;
            }else if(radioButton20.IsChecked == true)
            {
                tank = 20;
            }
            else
            {
                tank = int.Parse(textBoxOther.Text);
            }
            double range = m.GetRange(tank);

            labelResult.Content = "Your MPG is " + m.GetMilesPerGallon().ToString() + " Your range is " + m.GetRange(tank).ToString();
        }
    }
}
