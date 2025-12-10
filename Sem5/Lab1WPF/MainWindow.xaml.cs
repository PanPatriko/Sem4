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

namespace WPFLab1
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

        double result;

        private enum Operation
        {
            none,
            plus,
            minus,
            multiply,
            div,
            result
        }

        bool IsOperatorClicked = false;
        bool negativeValue = false;
        Operation currOperation;

        private  void Calculate(Operation operation)
        {
            string opr = "";
            switch(operation)
            {
                case Operation.plus:
                    opr = " + ";
                    break;
                case Operation.minus:
                    opr = " - ";
                    break;
                case Operation.div:
                    opr = " / ";
                    break;
                case Operation.multiply:
                    opr = " * ";
                    break;
                case Operation.result:
                    opr = " = ";
                    break;
            }
            if (currOperation != Operation.none)
            {
                switch (currOperation)
                {
                    case Operation.plus:

                        result += double.Parse(TBoxResult.Text);

                        break;
                    case Operation.minus:

                        result -= double.Parse(TBoxResult.Text);

                        break;
                    case Operation.div:

                        result /= double.Parse(TBoxResult.Text);

                        break;
                    case Operation.multiply:

                        result *= double.Parse(TBoxResult.Text);

                        break;
                }
                TBoxWorkArea.Text += TBoxResult.Text + opr;
                if (operation == Operation.result)
                    TBoxResult.Text = result.ToString();
            }
            else
            {
                if (result != 0)
                {
                    switch (operation)
                    {
                        case Operation.plus:

                            result += double.Parse(TBoxResult.Text);

                            break;
                        case Operation.minus:

                            result -= double.Parse(TBoxResult.Text);

                            break;
                        case Operation.div:

                            result *= double.Parse(TBoxResult.Text);

                            break;
                        case Operation.multiply:

                            result /= double.Parse(TBoxResult.Text);

                            break;
                    }
                    TBoxWorkArea.Text += TBoxResult.Text + opr;

                }
                else
                {
                    result = double.Parse(TBoxResult.Text);
                    TBoxWorkArea.Text = TBoxResult.Text + opr;
                }
            }

            currOperation = operation;
            IsOperatorClicked = true;
        }
        private void NumKeyClick(string key)
        {
            if (IsOperatorClicked)
            {
                TBoxResult.Text = "";
                IsOperatorClicked = false;
            }
            TBoxResult.Text += key;
        }
        private void BttnClear_Click(object sender, RoutedEventArgs e)
        {
            TBoxResult.Text = "";
            TBoxWorkArea.Text = "";
            result = 0;
        }
        private void BttnErase_Click(object sender, RoutedEventArgs e)
        {
            TBoxResult.Text = "";
        }
        private void Bttn1_Click(object sender, RoutedEventArgs e)
        {
            NumKeyClick("1");
        }

        private void Bttn2_Click(object sender, RoutedEventArgs e)
        {
            NumKeyClick("2");
        }

        private void Bttn3_Click(object sender, RoutedEventArgs e)
        {
            NumKeyClick("3");
        }

        private void Bttn4_Click(object sender, RoutedEventArgs e)
        {
            NumKeyClick("4");
        }

        private void Bttn5_Click(object sender, RoutedEventArgs e)
        {
            NumKeyClick("5");
        }

        private void Bttn6_Click(object sender, RoutedEventArgs e)
        {
            NumKeyClick("6");
        }

        private void Bttn7_Click(object sender, RoutedEventArgs e)
        {
            NumKeyClick("7");
        }

        private void Bttn8_Click(object sender, RoutedEventArgs e)
        {
            NumKeyClick("8");
        }

        private void Bttn9_Click(object sender, RoutedEventArgs e)
        {
            NumKeyClick("9");
        }

        private void Bttn0_Click(object sender, RoutedEventArgs e)
        {
            NumKeyClick("0");
        }
        private void BttnDot_Click(object sender, RoutedEventArgs e)
        {
            if (!TBoxResult.Text.Contains(","))
            {
                NumKeyClick(",");
            }
        }

        private void BttnResult_Click(object sender, RoutedEventArgs e)
        {
            if(TBoxResult.Text != "")
            {
                Calculate(Operation.result);
                result = 0;
                currOperation = Operation.none;
            }
        }

        private void BttnPlus_Click(object sender, RoutedEventArgs e)
        {
            if(TBoxResult.Text != "")
            {
                Calculate(Operation.plus);
            }
        }

        private void BttnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (TBoxResult.Text != "" && TBoxResult.Text != "-")
            {
                Calculate(Operation.minus);
            }
            else if (!TBoxResult.Text.Contains("-"))
            {
                TBoxResult.Text += "-";
                IsOperatorClicked = false;
            }
        }

        private void BttnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (TBoxResult.Text != "")
            {
                Calculate(Operation.multiply);
            }
        }

        private void BttnDiv_Click(object sender, RoutedEventArgs e)
        {
            if (TBoxResult.Text != "")
            {
                Calculate(Operation.div);
            }
        }
    }
}
