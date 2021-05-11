using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        private calculatorParse calcParser;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calcParser = new calculatorParse(this.tbDisplay);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tryAddDigit(sender);
         }

        private void tryAddDigit(object sender)
        {
            Button btn = (Button)sender;
            calcParser.addDigit(btn.Text[0]);

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tryAddDigit(sender);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tryAddDigit(sender);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tryAddDigit(sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tryAddDigit(sender);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tryAddDigit(sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tryAddDigit(sender);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tryAddDigit(sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tryAddDigit(sender);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tryAddDigit(sender);
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            calcParser.Backspace();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            calcParser.CE();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            calcParser.C();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            calcParser.addPoint();
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            btnM.Text = "";
            calcParser.MC();
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            calcParser.MR();
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            btnM.Text = "M";
            calcParser.MPlus();
                
        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {
            btnM.Text = "M";
            calcParser.MMinus();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calcParser.Calculate(calculatorParse.Operator.DIVIDE);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calcParser.Calculate(calculatorParse.Operator.TIMES);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            calcParser.Calculate(calculatorParse.Operator.PLUS);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            calcParser.Calculate(calculatorParse.Operator.MINUS);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            calcParser.Sqrt();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            calcParser.Calculate(calculatorParse.Operator.EQUAL);

        }
    }
}
