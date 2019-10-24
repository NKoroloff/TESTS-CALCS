using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CALCULATOR
{
    class Logic
    {
        Form1 form = new Form1();

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

        public void clearDisplay()
        {

        }


    }

}














/*function isError(a)
{
    if (isNaN(a)) return false;
    let d = String(a);
    for (let i = 0; i < d.length; i++)
    {
        let dot = '.';
        let idx = d.indexOf(dot);
        if (idx > 9 || d.length > 9 && idx == -1)
        {
            console.log(idx)
            return false;
        }
    }
}*/

/*function displayError()
{
    if (display.value === 'error')
    {
        model.setCountNumber(0);
        model.setMemoryNumber(0);
        model.setOperationType('')

    }
}*/

/*function cutDisplay(a)
{
    if (a == null)
    {
        return false
    }
    if (a.length > 9)
    {
        a = a.slice(0, 9);
    }
    return a;
}*/

/*function displayCut(a)
{
    display.value = cutDisplay(a)
}

const logic = {
    summ,
    minus,
    divide,
    multiply,
    cutDisplay,
    displayCut,
    displayError,
};

function cutValue(a)
{
    let d = String(a);
    a = cutDisplay(d);
    a = parseFloat(a);
    return a;
}*/
