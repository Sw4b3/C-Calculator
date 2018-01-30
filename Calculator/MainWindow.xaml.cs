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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num1;
        int num2;
        String operations;
        double answer;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ans.Text == "0")
            {
                ans.Text = "1";
            }
            else
            {
                ans.Text = ans.Text+1;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ans.Text == "0")
            {
                ans.Text = "2";
            }
            else
            {
                ans.Text = ans.Text + 2;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (ans.Text == "0")
            {
                ans.Text = "3";
            }
            else
            {
                ans.Text = ans.Text + 3;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (ans.Text == "0")
            {
                ans.Text = "4";
            }
            else
            {
                ans.Text = ans.Text + 4;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (ans.Text == "0")
            {
                ans.Text = "5";
            }
            else
            {
                ans.Text = ans.Text + 5;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (ans.Text == "0")
            {
                ans.Text = "6";
            }
            else
            {
                ans.Text = ans.Text + 6;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (ans.Text == "0")
            {
                ans.Text = "7";
            }
            else
            {
                ans.Text = ans.Text + 7;
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (ans.Text == "0")
            {
                ans.Text = "8";
            }
            else
            {
                ans.Text = ans.Text + 8;
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (ans.Text == "0")
            {
                ans.Text = "9";
            }
            else
            {
                ans.Text = ans.Text + 9;
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            num2 = Int32.Parse(ans.Text);
            switch (operations)
            {
                case "+":
                    answer = num1 + num2;
                    ans.Text = answer.ToString();
                    break;
                case "-":
                    answer = num1 - num2;
                    ans.Text = answer.ToString();
                    break;
                case "*":
                    answer = num1 * num2;
                    ans.Text = answer.ToString();
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        ans.Text = "ERROR";
                        break;
                    }
                    else
                    {
                        answer = num1 / num2;
                        ans.Text = answer.ToString();
                        break;
                    }
            }
            num1 = 0;
            num2 = 0;

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            num1 = Int32.Parse(ans.Text);
            operations = "+";
            ans.Text = "0";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            num1 = Int32.Parse(ans.Text);
            operations = "-";
            ans.Text = "0";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            num1 = Int32.Parse(ans.Text);
            operations = "*";
            ans.Text = "0";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            num1 = Int32.Parse(ans.Text);
            operations = "/";
            ans.Text = "0";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            ans.Text = "0";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            if (ans.Text == "0")
            {
                ans.Text = "0";
            }
            else
            {
                ans.Text = ans.Text + 0;
            }
        }
    }
}
