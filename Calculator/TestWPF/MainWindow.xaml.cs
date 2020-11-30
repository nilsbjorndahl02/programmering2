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

namespace TestWPF
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
        public void ClickButton(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                MainText.Text += button.Content;
            }
        }
                private void EqualsButton(Object sender, RoutedEventArgs e)
                {
                    if (MainText.Text.Contains("+"))
                    {
                        MainText.Text = Addition();
                    }
                    else if (MainText.Text.Contains("-"))
                    {
                        MainText.Text = Subtraction();
                    }
                    else if (MainText.Text.Contains("x"))
                    {
                        MainText.Text = Multiplication();
                    }
                    else if (MainText.Text.Contains("/"))
                    {
                        MainText.Text = Division();
                    }
                }
                private string Addition()
                {
                    var numbers = MainText.Text.Split("+");
                    var number1 = Convert.ToDouble(numbers[0]);
                    var number2 = Convert.ToDouble(numbers[1]);
                    var sum = number1 + number2;
                    return sum + "";
                }
                private string Subtraction()
                {
                    var numbers = MainText.Text.Split("-");
                    var number1 = Convert.ToDouble(numbers[0]);
                    var number2 = Convert.ToDouble(numbers[1]);
                    var sum = number1 - number2;
                    return sum + "";
                }
                private string Multiplication()
                {
            var numbers = MainText.Text.Split("x");
                    var number1 = Convert.ToDouble(numbers[0]);
                    var number2 = Convert.ToDouble(numbers[1]);
                    var sum = number1 * number2;
                    return sum + "";
                }
                private string Division()
                {
                    var numbers = MainText.Text.Split("/");
                    var number1 = Convert.ToDouble(numbers[0]);
                    var number2 = Convert.ToDouble(numbers[1]);
                    var sum = number1 / number2;
                    return sum + "";
                }
                private void DeleteButton(Object sender, RoutedEventArgs e)
                {
                    MainText.Text = "";

                }
    }
}
