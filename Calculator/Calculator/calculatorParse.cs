using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class calculatorParse
    {
        private TextBox textBoxDisplay;

        public enum displayMode
        {
            CLEAR, APPEND
        }

        public enum Operator
        {
            PLUS, MINUS, DIVIDE, TIMES, EQUAL
        }

        private displayMode DisplayMode = calculatorParse.displayMode.CLEAR;
        private Operator operatorOne = Operator.EQUAL;
        private double totalSum;
        private double memory;




        public calculatorParse(TextBox textBoxDisplay)
        {
            this.textBoxDisplay = textBoxDisplay;
        
        }

        public void Sqrt()
        {
            double result = Math.Sqrt(getCurrentDigit());
            textBoxDisplay.Text = "" + result;
        }

        public void MPlus()
        {
            memory += getCurrentDigit();
        }

        public void MMinus()
        {
            memory -= getCurrentDigit();
        }

        public void MR()
        {
            textBoxDisplay.Text = "" + memory;
        }

        public void MC()
        {
            memory = 0;
        }

        public void addPoint()
        {
            if (!textBoxDisplay.Text.Contains("."))
            {
                textBoxDisplay.Text += ".";
            }
        }

        public void CE()
        {
            textBoxDisplay.Text = "0";
            DisplayMode = displayMode.CLEAR;
        }

        public void C()
        {
            CE();
            totalSum = 0;
            operatorOne = Operator.EQUAL;
        }

        public void Backspace()
        {
            string disp = textBoxDisplay.Text;

            if (disp.Length == 1)
            {
                textBoxDisplay.Text = "0";
                DisplayMode = displayMode.CLEAR;
            }
            else
            {
                disp = disp.Substring(0, disp.Length - 1);
                textBoxDisplay.Text = disp;
            }
            
        }


        public double getCurrentDigit()
        {
            return double.Parse(textBoxDisplay.Text);
        }

        public void Calculate(Operator operatorThree)
        {
            Operator operatorTwo = this.operatorOne;
            this.operatorOne = operatorThree;
            double curValue = getCurrentDigit();
            DisplayMode = displayMode.CLEAR;

            switch(operatorTwo)
                {
                case Operator.PLUS:
                    totalSum += curValue;
                    break;

                case Operator.MINUS:
                    totalSum -= curValue;
                    break;
                case Operator.DIVIDE:
                    totalSum /= curValue;
                    break;
                case Operator.TIMES:
                    totalSum *= curValue;
                    break;

                default:
                    totalSum = curValue;
                    return;


           }
            textBoxDisplay.Text = "" + totalSum;
        }

        public void addDigit(char digit)
        {

            double currentValue = getCurrentDigit();


            if (currentValue == 0 && digit == '0')
                return;

        
            if(DisplayMode == displayMode.CLEAR)
            {
                textBoxDisplay.Text = "" + digit;
                DisplayMode = displayMode.APPEND;

            }
            else
            {
                
                
               
                textBoxDisplay.Text += digit;
            }
        }
    }
}
