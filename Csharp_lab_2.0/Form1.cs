using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_lab_2._0
{
    public partial class Form1 : Form
    {
        private static string FuncSimpleNum(long parse)
        {
            string result = null;
            //long j = 2; 
            //bool simple = true;
            while (parse % 2 == 0)
            {
                parse /= 2;
                result += "2";
                result += " * ";
            }
            long b = 3;
            long c = (long)Math.Sqrt(parse) + 1;

            while (b < c)
            {
                if (parse % b == 0)
                {
                    parse = parse / b;
                    result += b;
                    if (parse == 1)
                        break;
                    else
                        result += " * ";

                }
                else
                    b += 2;

            }
            if (b * b >= parse)
            {
                if (parse == 1)
                {
                    parse = 0;
                }
                else
                    result += parse;
            }
            return result;
            ////
            /*while (simple)
            {

                if (parse % j == 0)
                {
                    simpleNums += $"{j}";
                    //Console.Write($"{j}");
                    parse = parse / j;
                    if (parse == 1)
                        simple = false;
                    else
                        simpleNums += " * ";
                        //Console.Write(" * ");
                }
                else
                {
                    j++;
                }
            }*/
            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var parseUlongCount = textBox1.Text;
            long longNum = Math.Abs(long.Parse(parseUlongCount));
            label1.Text = FuncSimpleNum(longNum);
        }
    }
}
