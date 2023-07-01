using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace calculator
{
   
    public partial class MainWindow : Window
    {
        float a, b;
        int count;
        bool znak = true;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textLabel.Text = textLabel.Text + 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textLabel.Text = textLabel.Text + 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textLabel.Text = textLabel.Text + 2;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textLabel.Text = textLabel.Text + 3;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textLabel.Text = textLabel.Text + 4;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            textLabel.Text = textLabel.Text + 5;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            textLabel.Text = textLabel.Text + 6;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            textLabel.Text = textLabel.Text + 7;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            textLabel.Text = textLabel.Text + 8;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            textLabel.Text = textLabel.Text + 9;
        }


        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            textLabel.Text = textLabel.Text + ",";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textLabel.Text);
            textLabel.Clear();
            count = 2;
            textLabel2.Text = a.ToString() + "-";
            znak = true;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textLabel.Text);
            textLabel.Clear();
            count = 3;
            textLabel2.Text = a.ToString() + "*";
            znak = true;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textLabel.Text);
            textLabel.Clear();
            count = 4;
            textLabel2.Text = a.ToString() + "/";
            znak = true;
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textLabel.Text);
            textLabel.Clear();
            count = 5;
            textLabel2.Text = "√"+ a.ToString();
            znak = true;
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textLabel.Text);
            textLabel.Clear();
            count = 6;
            textLabel2.Text = a.ToString() + "^2";
            znak = true;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textLabel.Text);
            textLabel.Clear();
            count = 1;
            textLabel2.Text = a.ToString() + "+";
            znak = true;
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            textLabel.Text = "";
            textLabel2.Text = "";
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            if (znak == true)
            {
                textLabel.Text = "-" + textLabel.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textLabel.Text = textLabel.Text.Replace("-", "");
                znak = true;
            }
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            calculate();
            textLabel2.Text = "";
        }

        private void calculate()
        {
                switch (count)
                {
                    case 1:
                        b = a + float.Parse(textLabel.Text);
                        textLabel.Text = b.ToString();
                        break;
                    case 2:
                        b = a - float.Parse(textLabel.Text);
                        textLabel.Text = b.ToString();
                        break;
                    case 3:
                        b = a * float.Parse(textLabel.Text);
                        textLabel.Text = b.ToString();
                        break;
                    case 4:
                        b = a / float.Parse(textLabel.Text);
                        textLabel.Text = b.ToString();
                        break;
                    case 5:
                        b = (float)Math.Sqrt(a);
                        textLabel.Text = b.ToString();
                        break;
                    case 6:
                        b = (float)Math.Pow(a, 2);
                        textLabel.Text = b.ToString();
                    break;
                    default:
                        break;
                }

        }
    }
}
