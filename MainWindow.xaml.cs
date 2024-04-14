using System;
using System.Collections.Generic;
using System.Data;
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

namespace _231_335_Шматов.А.М._2_
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

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_1.Content;
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_2.Content;
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_3.Content;
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_4.Content;
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_5.Content;
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_6.Content;
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_7.Content;
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_8.Content;
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_9.Content;
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            if (textlabel.Text == "")
            {

            }
            else
            {
                textlabel.Text += Button_0.Content;
            }
        }

        private void Button_AC_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text = "";
        }

        private void Button_plus_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_plus.Content;
        }

        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_minus.Content;
        }

        private void Button_multi_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_multi.Content;
        }

        private void Button_div_Click(object sender, RoutedEventArgs e)
        {
            textlabel.Text += Button_div.Content;
        }

        private void Button_eq_Click(object sender, RoutedEventArgs e)
        {
            string value = new DataTable().Compute(textlabel.Text, null).ToString();
            textlabel.Text = value;
        }
    }
}
