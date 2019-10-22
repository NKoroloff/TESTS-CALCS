using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isCheck = true;
        private bool isResult = true;
        private char operationType = '\0';
        private double countNumber = 0.0;
        private double memoryNumber = 0.0;

        public void SetIsCheck(bool value)
        {
            this.isCheck = value;
        }

        public bool GetIsCheck()
        {
            return this.isCheck;
        }

        public void SetIsResult(bool value)
        {
            this.isResult = value;
        }

        public bool GetIsResult()
        {
            return this.isResult;
        }

        public void SetCountNumber(double value)
        {
            this.countNumber = value;
        }

        public double GetCountNumber()
        {
            return this.countNumber;
        }

        public void SetMemoryNumber(double value)
        {
            this.memoryNumber = value;
        }

        public double GetMemoryNumber()
        {
            return this.memoryNumber;
        }

        public void SetOperationType(char value)
        {
            this.operationType = value;
        }

        public char GetOperationType()
        {
            return this.operationType;
        }

        public void SetDisplayValue(string value)
        {
            if (textBox1.Text.Length > 9) return;
            textBox1.Text += value;
        }

        public string GetDisplayValue()
        {
            return textBox1.Text;
        }
        public void onOperationsClickBtn(char operType)
        {
            if (IsError() == false) return;


            SetMemoryNumber(Convert.ToDouble(GetDisplayValue() ));
            SetOperationType(operType);
            SetIsCheck(true);
            SetIsResult(true);
        }


















        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (IsError() == false) return;
            LastOperation();
            onOperationsClickBtn('-');
        }

        private void button14_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            isZero();
            if (IsError() == false) return;
            if (GetIsCheck() == true)
            {
                textBox1.Text = Convert.ToString(' ');
            }
            SetIsCheck(false);
            SetDisplayValue(Convert.ToString(2));
        }

        private void button8_Click(object sender, EventArgs e)
        {           
            if (IsError() == false) return;
            LastOperation();
            onOperationsClickBtn('/');
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (IsError() == false) return;
            LastOperation();
            onOperationsClickBtn('*');
            
        }

        private void b1_Click(object sender, EventArgs e)
        {
            isZero();
            if (IsError() == false) return;
            if (GetIsCheck() == true)
            {
                textBox1.Text = Convert.ToString(' ');
            }
            SetIsCheck(false);
            SetDisplayValue(Convert.ToString(1));

        }

        private void button9_Click(object sender, EventArgs e)
        {
            isZero();
            if (IsError() == false) return;
            if (GetIsCheck() == true)
            {
                textBox1.Text = Convert.ToString(' ');
            }
            SetIsCheck(false);
            SetDisplayValue(Convert.ToString(3));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            isZero();
            if (IsError() == false) return;
            if (GetIsCheck() == true)
            {
                textBox1.Text = Convert.ToString(' ');
            }
            SetIsCheck(false);
            SetDisplayValue(Convert.ToString(4));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isZero();
            if (IsError() == false) return;
            if (GetIsCheck() == true)
            {
                textBox1.Text = Convert.ToString(' ');
            }
            SetIsCheck(false);
            SetDisplayValue(Convert.ToString(5));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            isZero();
            if (IsError() == false) return;
            if (GetIsCheck() == true)
            {
                textBox1.Text = Convert.ToString(' ');
            }
            SetIsCheck(false);
            SetDisplayValue(Convert.ToString(6));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isZero();
            if (IsError() == false) return;
            if (GetIsCheck() == true)
            {
                textBox1.Text = Convert.ToString(' ');
            }
            SetIsCheck(false);
            SetDisplayValue(Convert.ToString(7));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isZero();
            if (IsError() == false) return;
            if (GetIsCheck() == true)
            {
                textBox1.Text = Convert.ToString(' ');
            }
            SetIsCheck(false);
            SetDisplayValue(Convert.ToString(8));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            isZero();
            if (IsError() == false) return;
            if (GetIsCheck() == true)
            {
                textBox1.Text = Convert.ToString(' ');
            }
            SetIsCheck(false);
            SetDisplayValue(Convert.ToString(9));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (IsError() == false) return;
            if (Convert.ToString(textBox1.Text) == Convert.ToString("0"))
            {
                return;
            }

            if (GetIsCheck() == true)
            {
                textBox1.Text = Convert.ToString(' ');
            }
            SetIsCheck(false);
            SetDisplayValue(Convert.ToString(0));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (IsError() == false) return;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (Convert.ToString(textBox1.Text[i]) == Convert.ToString(',')) return;
            }
            SetDisplayValue(Convert.ToString(','));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (IsError() == false) return;
            LastOperation();
            onOperationsClickBtn('+');
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (IsError() == false) return;
            getResultt();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SetMemoryNumber(0);
            SetOperationType(' ');
            textBox1.Text = "0";
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        public void LastOperation()
        {
            if (GetIsCheck())
            {
                SetMemoryNumber(Convert.ToDouble(textBox1.Text));
            }
            if (Convert.ToBoolean(GetMemoryNumber()))
            {
                switch (GetOperationType())
                {
                    case '+':
                        SetMemoryNumber(summ(GetMemoryNumber(), Convert.ToDouble(textBox1.Text)));
                        break;
                    case '-':
                        SetMemoryNumber(minus(GetMemoryNumber(), Convert.ToDouble(textBox1.Text)));
                        break;
                    case '/':
                        SetMemoryNumber(divide(GetMemoryNumber(), Convert.ToDouble(textBox1.Text)));
                        break;
                    case '*':
                        SetMemoryNumber(multiply(GetMemoryNumber(), Convert.ToDouble(textBox1.Text)));
                        break;
                }
                if (Convert.ToString(GetMemoryNumber()).Length > 9)
                {
                    textBox1.Text = "error";
                }
                else
                {
                    textBox1.Text = Convert.ToString(GetMemoryNumber());
            }


        }
        }

        public double summ(double a, double b)
        {
            return a += b;

        }

        public double minus(double a, double b)
        {
            return a -= b;

        }

        public double divide(double a, double b)
        {
            if (b == 0)
            {
                return 0;
            }
            else
            {
                return a /= b;
            }
        }

        public double multiply(double a, double b)
        {            
            return a *= b;
                       
        }

        public bool isError(double a)
        {
            if (double.IsNaN(a))
            {
                return false;
            }
            string d = a.ToString();
            int idx = d.IndexOf(',');
            if (idx > 9 || d.Length > 9 && idx == -1)
            {
                return false;
            }

            return true;
        }

        public void displayError()
        {
            if (textBox1.Text == "error")
            {
                SetCountNumber(0);
                SetMemoryNumber(0);
                SetOperationType('\0');
            }
        }

        public double cutValue(double a)
        {
            string d = a.ToString();
            d = cutDisplay(d);
            a = double.Parse(d);
            return a;
        }


        public string cutDisplay(string a)
        {
            if (a == null)
            {
                return "";
            }
            if (a.Length > 9)
            {
                a = a.Substring(0, 9);
            }
            return a;
        }
        public void displayCut(string a)
        {
            textBox1.Text = cutDisplay(a);
        }

        private void getResultt()
        {
            if (Convert.ToBoolean(GetMemoryNumber()))
            {
                switch (GetOperationType())
                {
                    case '+':
                        SetMemoryNumber(summ(GetMemoryNumber(), Convert.ToDouble(textBox1.Text)));
                        break;
                    case '-':
                        SetMemoryNumber(minus(GetMemoryNumber(), Convert.ToDouble(textBox1.Text)));
                        break;
                    case '/':
                        SetMemoryNumber(divide(GetMemoryNumber(), Convert.ToDouble(textBox1.Text)));
                        break;
                    case '*':
                        SetMemoryNumber(multiply(GetMemoryNumber(), Convert.ToDouble(textBox1.Text)));
                        break;
                }
                textBox1.Text = Convert.ToString(GetMemoryNumber());
            }
            SetIsResult(false);
            SetOperationType(' ');
            SetMemoryNumber(0);
            SetIsCheck(true);      
        }

        private void isZero()
        {
              
            if (textBox1.Text == "0" || textBox1.Text == "error")
            {
                textBox1.Text = "";
            }
        }

        private bool IsError()
        {
    
            if (textBox1.Text == "error")
            {
                return false;
            }
            return true;
        }
    }
}