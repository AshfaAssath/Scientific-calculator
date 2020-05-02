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
        Double results = 0;
        String operation = "";
        bool enter_value = false;
        float iCelcius, IFarenheit, iKelvin;
        char IOperation ;
        float ikg, ig, ipound, iounce;
        char IUnit;
        public Form1()
        {
            InitializeComponent();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 307;
            textBox1.Width = 246;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 601;
            textBox1.Width = 534;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 307;
            textBox1.Width = 246;
        }

        private void btn_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (enter_value))
                textBox1.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if(num.Text ==".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + num.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length >0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1, 1);
            }

            if (textBox1.Text=="")
            {
                textBox1.Text = "0";
            }
        }

        private void Arithmetic_operation(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            label1.Text = System.Convert.ToString(results) + "" + operation;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            switch (operation)
            {
                case "+": textBox1.Text = (results + Double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (results - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (results / Double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (results * Double.Parse(textBox1.Text)).ToString();
                    break;

                case "Mod":
                    textBox1.Text = (results % Double.Parse(textBox1.Text)).ToString();
                    break;

                case "Exp":
                    Double i = Double.Parse(textBox1.Text);
                    Double q;
                    q = (results);
                    textBox1.Text = Math.Exp(i*Math.Log(q*4)).ToString();
                    break;

            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.1415926535897932384626433832795028841971";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Double ilog = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("log" + " (" + (textBox1.Text) + ")");
            ilog = Math.Log10(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
            
        }

        private void button38_Click(object sender, EventArgs e)
        {

            Double sq = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("sqrt" + " (" + (textBox1.Text) + ")");
            sq = Math.Sqrt(sq);
            textBox1.Text = System.Convert.ToString(sq);
        }

        private void button36_Click(object sender, EventArgs e)
        {

            Double qSinh = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("sinh" + " (" + (textBox1.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            textBox1.Text = System.Convert.ToString(qSinh);
        }

        private void button35_Click(object sender, EventArgs e)
        {

            Double qSin = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("sin" + " (" + (textBox1.Text) + ")");
            qSin = Math.Sin(qSin);
            textBox1.Text = System.Convert.ToString(qSin);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Double qCosh = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("cosh" + " (" + (textBox1.Text) + ")");
            qCosh = Math.Cosh(qCosh);
            textBox1.Text = System.Convert.ToString(qCosh);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Double qCos = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("cos" + " (" + (textBox1.Text) + ")");
            qCos = Math.Cos(qCos);
            textBox1.Text = System.Convert.ToString(qCos);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Double qTanh = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("tanh" + " (" + (textBox1.Text) + ")");
            qTanh = Math.Tanh(qTanh);
            textBox1.Text = System.Convert.ToString(qTanh);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Double qTan = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("tan" + " (" + (textBox1.Text) + ")");
            qTan = Math.Tanh(qTan);
            textBox1.Text = System.Convert.ToString(qTan);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 2);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 16);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 8);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text)* Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0/  Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Double ilog = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("log" + " (" + (textBox1.Text) + ")");
            ilog = Math.Log(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            switch (IOperation)
            {
                case 'C': //Celsius to Farenheit
                    iCelcius = float.Parse(textBox2.Text);
                    label3.Text = ((((9* iCelcius) / 5)+32).ToString());break;

                case 'F': //Farenheit to Celsius 
                    IFarenheit=float.Parse(textBox2.Text);
                    label3.Text = ((((IFarenheit - 32) * 5) / 9).ToString()); break;


                case 'K': //Celsius to Kelvin
                    iKelvin = float.Parse(textBox2.Text);
                    label3.Text = (((((9*iKelvin) /5)+32)+273.15).ToString()); break;
            }

        }

        private void rbFarToCel_CheckedChanged(object sender, EventArgs e)
        {
            IOperation = 'F';
        }

        private void rbCelToKel_CheckedChanged(object sender, EventArgs e)
        {
            IOperation = 'K';
        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            label3.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            IUnit = '2';
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            IUnit = '3';
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            IUnit = '4';
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            IUnit = '5';
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            IUnit = '6';
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            IUnit = '7';
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            IUnit = '8';
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            IUnit = '9';
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            IUnit = 'A';
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            IUnit = 'B';
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            IUnit = 'C';
        }

        private void button44_Click(object sender, EventArgs e)
        {
            switch (IUnit)
            {
                case '1': //Kg to g
                    ikg = float.Parse(textBox3.Text);
                    label5.Text = ((ikg*1000).ToString()); break;

                case '2': //Kg to ounce 
                    ikg = float.Parse(textBox3.Text);
                    label5.Text = ((ikg * 1000).ToString()); break;


                case '3': //Kg to pound
                    ikg = float.Parse(textBox3.Text);
                    label5.Text = ((ikg * 2.204623).ToString()); break;

                case '4': //pound to Kg
                    ipound = float.Parse(textBox3.Text);
                    label5.Text = ((ipound * 0.453592).ToString()); break;

                case '5': //pound to g
                    ipound = float.Parse(textBox3.Text);
                    label5.Text = ((ipound* 453.5924).ToString()); break;

                case '6': //pound to ounce
                    ipound = float.Parse(textBox3.Text);
                    label5.Text = ((ipound*16).ToString()); break;

                case '7': //g to Kg
                    ig = float.Parse(textBox3.Text);
                    label5.Text = ((ig *0.001 ).ToString()); break;

                case '8': //g to ounce
                    ig = float.Parse(textBox3.Text);
                    label5.Text = ((ig* 0.035274).ToString()); break;

                case '9': //g to pound
                    ig = float.Parse(textBox3.Text);
                    label5.Text = ((ig* 0.00220462).ToString()); break;

                case 'A': //ounce to Kg
                    iounce = float.Parse(textBox3.Text);
                    label5.Text = ((iounce * 0.0283495).ToString()); break;

                case 'B': //ounce to g
                    iounce = float.Parse(textBox3.Text);
                    label5.Text = ((iounce* 28.3495).ToString()); break;

                case 'C': //ounce to pound
                    iounce = float.Parse(textBox3.Text);
                    label5.Text = ((iounce* 0.0625).ToString()); break;



            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            label5.Text = "";
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 906;
            textBox1.Width = 534;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            IUnit = '1';
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void rbCelToFar_CheckedChanged(object sender, EventArgs e)
        {
            IOperation = 'C';
        }
    }
}
