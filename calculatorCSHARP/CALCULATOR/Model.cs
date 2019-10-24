using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
    class Model
    {
      
       

        private bool isCheck = true;
        private bool isResult = true;
        private char operationType = '\0';
        private double countNumber = 0.0;
        private double memoryNumber = 0.0;
        private double displayValue = 0.0;


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
            textBox1.Text = value;
        }

        public string GetDisplayValue()
        {
            return textBox1.Text;
        }
    }
}
