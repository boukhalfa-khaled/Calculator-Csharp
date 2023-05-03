using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Calculator : Form
    {
        double prevNum = 0;
        string operation = "";
        bool newNumber = true;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 331;
            
            txtResult.Width = 312;
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (newNumber)
            {
                txtResult.Text = button.Text;
                newNumber = false;
            }
            else
            {
                if (txtResult.Text == "0") txtResult.Text = ""; 
                txtResult.Text += button.Text;
            }
        }

        private void numberOper(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double currentNum = double.Parse(txtResult.Text);
            if (operation == "")
            {
                prevNum = currentNum;
            }
            else
            {
                prevNum = Calculate(prevNum, currentNum, operation);
                txtResult.Text = prevNum.ToString();
            }
            operation = button.Text;
            newNumber = true;
        }

        private void btnEqualsClick(object sender, EventArgs e)
        {
            double currentNum = double.Parse(txtResult.Text);
            prevNum = Calculate(prevNum, currentNum, operation);
            txtResult.Text = prevNum.ToString();
            operation = "";
            newNumber = true;
        }

        private double Calculate(double num1, double num2, string op)
        {
            switch (op)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                case "Exp" :
                    return Math.Pow(num1, num2);
                case "Mod" :
                    return num1 % num2;
                default:
                    return 0;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            prevNum = 0;
            operation = "";
            newNumber = true;
        }

        private void btnClearEnteryclick(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void PMclick(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1* q) ;
        }

        private void backSpace_click(object sender, EventArgs e)
        {
            if(txtResult.Text.Length > 0 )
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1 , 1 );
            }
            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void TxtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void FileToolStripMenuItem_Click_2(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void StandardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Width = 331;
            txtResult.Width = 312;
        }

        private void ScintificeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Width = 641;
            txtResult.Width = 622;
        }

        private void pi_clic(object sender, EventArgs e)
        {
            txtResult.Text = "3.141592653589976323";
        }

        private void log_click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtResult.Text);
            logg = Math.Log10(logg);
            txtResult.Text  = Convert.ToString(logg); 
        }

        private void sqrt_click(object sender, EventArgs e)
        {
            double sqrt = Convert.ToDouble(txtResult.Text);
            sqrt = Math.Sqrt(sqrt);
            txtResult.Text = Convert.ToString(sqrt);
        }

        private void x2_click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtResult.Text);
            x = x * x;
            txtResult.Text = Convert.ToString(x);
        }

        private void x3_click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtResult.Text);
            x = x * x * x;
            txtResult.Text = Convert.ToString(x);
        }

        private void oneoverx(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtResult.Text);
            x = 1 / x;
            txtResult.Text = Convert.ToString(x);
        }

        private void signH_click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtResult.Text);
            x = Math.Sinh(x);
            txtResult.Text = Convert.ToString(x);
        }

        private void sin_click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtResult.Text);
            x = Math.Sin(x);
            txtResult.Text = Convert.ToString(x);
        }

        private void CosH_click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtResult.Text);
            x = Math.Cosh(x);
            txtResult.Text = Convert.ToString(x);
        }

        private void cos_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtResult.Text);
            x = Math.Cos(x);
            txtResult.Text = Convert.ToString(x);
        }

        private void tan_click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtResult.Text);
            x = Math.Tanh(x);
            txtResult.Text = Convert.ToString(x);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void floatnumber_click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains("."))
            {
                txtResult.Text += ".";
            }
        }

        private void lnx_click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtResult.Text);
            x = Math.Log(x);
            txtResult.Text = Convert.ToString(x);
        }

        private void poutcentage_click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtResult.Text);
            x = x / 100;
            txtResult.Text = Convert.ToString(x);
        }

        private void dec_click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtResult.Text);
            int i = Convert.ToInt32(dec);
            txtResult.Text = i.ToString();
        }

        private void bin_click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 2);
        }

        private void hex_click(object sender, EventArgs e)
        { 
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 16);
        }

        private void oct_click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 8);
        }
    }
}
