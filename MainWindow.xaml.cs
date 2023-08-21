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

namespace Ejemplo1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        long num1 = 0;
        long num2 = 0;
        string operacion = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                num1 = (num1 * 10) + 1;
                Resultado.Text = num1.ToString();

            }
            else
            {
                num2 = (num2 * 10) + 1;
                Resultado.Text = num2.ToString();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                num1 = (num1 * 10) + 2;
                Resultado.Text = num1.ToString();

            }
            else
            {
                num2 = (num2 * 10) + 2;
                Resultado.Text = num2.ToString();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                num1 = (num1 * 10) + 3;
                Resultado.Text = num1.ToString();

            }
            else
            {
                num2 = (num2 * 10) + 3;
                Resultado.Text = num2.ToString();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                num1 = (num1 * 10) + 4;
                Resultado.Text = num1.ToString();

            }
            else
            {
                num2 = (num2 * 10) + 4;
                Resultado.Text = num2.ToString();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                num1 = (num1 * 10) + 5;
                Resultado.Text = num1.ToString();

            }
            else
            {
                num2 = (num2 * 10) + 5;
                Resultado.Text = num2.ToString();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                num1 = (num1 * 10) + 6;
                Resultado.Text = num1.ToString();

            }
            else
            {
                num2 = (num2 * 10) + 6;
                Resultado.Text = num2.ToString();
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                num1 = (num1 * 10) + 7;
                Resultado.Text = num1.ToString();

            }
            else
            {
                num2 = (num2 * 10) + 7;
                Resultado.Text = num2.ToString();
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                num1 = (num1 * 10) + 8;
                Resultado.Text = num1.ToString();

            }
            else
            {
                num2 = (num2 * 10) + 8;
                Resultado.Text = num2.ToString();
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                num1 = (num1 * 10) + 9;
                Resultado.Text = num1.ToString();

            }
            else
            {
                num2 = (num2 * 10) + 9;
                Resultado.Text = num2.ToString();
            }
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                num1 = (num1 * 10) + 0;
                Resultado.Text = num1.ToString();

            }
            else
            {
                num2 = (num2 * 10) + 0;
                Resultado.Text = num2.ToString();
            }
        }

        private void Button_Click_Sumar(object sender, RoutedEventArgs e)
        {
            operacion = "+";
            Resultado.Text = "0";
        }

        private void Button_Click_Restar(object sender, RoutedEventArgs e)
        {
            operacion = "-";
            Resultado.Text = "0";
        }

        private void Button_Click_Mult(object sender, RoutedEventArgs e)
        {
            operacion = "*";
            Resultado.Text = "0";
        }

        private void Button_Click_Div(object sender, RoutedEventArgs e)
        {
            operacion = "/";
            Resultado.Text = "0";
        }

        private void Button_Click_Resp(object sender, RoutedEventArgs e)
        {
            switch (operacion)
            {
                case "+":
                    Resultado.Text = (num1+num2).ToString();
                    break;
                case "-":
                    Resultado.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    Resultado.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    Resultado.Text = (num1 / num2).ToString();
                    break;
            }
            num1 = 0;
            num2 = 0;
            operacion = "";
        }

        private void Button_Click_Cambio(object sender, RoutedEventArgs e)
        {
            Resultado.Text = (-1*int.Parse(Resultado.Text)).ToString();
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {

                num1 = 0;

            }
            else
            {
                num2 = 0;
            }
            Resultado.Text = "0";
        }

        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operacion = "0";
            Resultado.Text="0"; 
        }

        private void Button_Click_Atras(object sender, RoutedEventArgs e)
        {
            if(operacion == "")
            {

                num1 = (num1 / 10);
                Resultado.Text = num1.ToString();

            }
            else
            {
                num2 = (num2 / 10);
                Resultado.Text = num2.ToString();
            }
        }
    }
}
