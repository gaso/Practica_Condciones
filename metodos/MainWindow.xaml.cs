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

namespace metodos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        String mensaje(String num1, String num2 , String r , String op){
            String msj = "NA";
            
            try {
                msj = String.Format("{0} {1} {2} = {3}", num1, op, num2, r);
            }
            catch (Exception e) {
                MessageBox.Show("Error simulando Operacion => " + e);
            }
             
            return msj;
        }

        private void event_sumar(object sender, RoutedEventArgs e)
        {
            operacion("+");
        }

        private void operacion(String op) {
            try{
                int num1 = Int32.Parse(cNum1.Text);
                int num2 = Int32.Parse(cNum2.Text);

                int result = 0;

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;

                    case "-":
                        result = num1 - num2;
                        break;

                    case "*":
                        result = num1 * num2;
                        break;

                    case "/":
                        result = num1 / num2;
                        break;

                    case "%":
                        result = num1 % num2;
                        break;

                    default:
                        operacion("+");
                        break;

                }

                cResult.Text = result.ToString();

                lOperacion.Text = mensaje(num1.ToString(), num2.ToString(), result.ToString(), op);
            }
            catch (Exception e){
                MessageBox.Show("Error Sumando " + e);
            }
        }

        private void event_clear(object sender, RoutedEventArgs e)
        {
            cNum1.Text = "";
            cNum2.Text = "";
            cResult.Text = "";
            lOperacion.Text = "Calculadora";
        }

        private void event_resta(object sender, RoutedEventArgs e)
        {
            operacion("-");
        }

        private void event_divi(object sender, RoutedEventArgs e)
        {
            operacion("/");
        }

        private void event_multi(object sender, RoutedEventArgs e)
        {
            operacion("*");
        }

        private void event_mod(object sender, RoutedEventArgs e)
        {
            operacion("%");
        }

    }
}
