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

namespace Assignment8_1
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
            Total t = new Assignment8_1.Total();
            t.MealPrice = double.Parse(textBoxMealPrice.Text);

           
            if(checkBox10.IsChecked == true)
            {
                t.Tip = .1;
            }
            else if(checkBox15.IsChecked == true)
            {
                t.Tip = .15;
            }
            else if(checkBox20.IsChecked == true)
            {
                t.Tip = .2;
            }
            else
            {
                t.Tip = double.Parse(textBoxOther.Text);
                if(t.Tip > 1)
                {
                    t.Tip = t.Tip / 100;
                }
            }
            double grandTotal = t.TotalBill();

            labelTotal.Content = "Your total bill, including tax and tip is: $" + t.TotalBill().ToString("0.00");
        }
    }
}
