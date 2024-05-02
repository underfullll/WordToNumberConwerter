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

namespace WordToNumberConwerter_in_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            wordTextBox.KeyDown += WordTextBox_KeyDown;
        }
        private void WordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ConvertButton_Click(sender, e);
            }
        }
        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            string word = wordTextBox.Text.ToLower();
            string result = "";

            switch (word)
            {
                case "ноль":
                case "zero":
                    result = "0";
                    break;
                case "один":
                case "one":
                    result = "1";
                    break;
                case "два":
                case "two":
                    result = "2";
                    break;
                case "три":
                case "three":
                    result = "3";
                    break;
                case "четыре":
                case "four":
                    result = "4";
                    break;
                case "пять":
                case "five":
                    result = "5";
                    break;
                case "шесть":
                case "six":
                    result = "6";
                    break;
                case "семь":
                case "seven":
                    result = "7";
                    break;
                case "восемь":
                case "eight":
                    result = "8";
                    break;
                case "девять":
                case "nine":
                    result = "9";
                    break;
                default:
                    result = "Invalid input";
                    break;
            }

            resultTextBlock.Text = result;
        }
    }
}