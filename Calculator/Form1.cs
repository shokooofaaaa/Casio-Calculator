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
    public partial class Form1: Form
    {
        double num1;
        double num2;
        double mplus;
        double mminus;
        double mr;
        double result;
        double resultm;
        string op = "";
        bool checkpoint = false;
        bool newnumber = true;
        int sign = 1;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            mplus = 0;
            mminus = 0;

            resultm = 0;
            lcd.Text = "0";

            lblsign.Text = "";

            sign = 1;
            lblm.Text = "";
            newnumber = true;

            num1 = 0;
            num2 = 0;
            op = "";
            result = 0;


        }

        private void btnpercent_Click(object sender, EventArgs e)
        {
            num2 = sign * Convert.ToDouble(lcd.Text);

            switch(op)
            {
                case "+":
                    result = num1 + ((num1 * num2) / 100);
                    break;

                case "=":
                    result = num1 - ((num1 * num2) / 100);
                 
                   break;

                case "*":
                    result =num1 *( num2 / 100);
                    break;


                case "/":
                    result = num1/((num1*num2)/100);
                    break;
            }

            if(result < 0)
            {
                sign = -1;
                result = sign * result;
                lblsign.Text = "-";



            }


            else if (result > 0)
            {
                sign = 1;
                result = sign * result;
                lblsign.Text = "";



            }

            lcd.Text = result.ToString();
            checkpoint = false;
            newnumber = true;

            num1 = 0;
            num2 = 0;






        }

        private void btnplusminus_Click(object sender, EventArgs e)
        {
            if(lblsign.Text == "")
            {
                lblsign.Text = "-";
                sign = -sign;

            }

            else if (lblsign.Text == "-")
            {
                lblsign.Text = "";
                sign = -sign;

            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            lcd.Text = "0";
            lblsign.Text = "";
            newnumber = true;
            num2 = 0;
            result = 0;
            sign = 1;
            checkpoint = false;
         
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void btnoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            if(newnumber == false && checkpoint==false)

            {
                lcd.Text = lcd.Text + ".";

                checkpoint = true;

            }

            else if(newnumber == true && checkpoint==false)
            {

                lcd.Text = "";
                lcd.Text = lcd.Text + ".";

                newnumber = false;
                checkpoint = true;


            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(newnumber == false)
            {
                lcd.Text = lcd.Text + "0";



            }

            else if(newnumber ==true)
            {

                lcd.Text = "";
                lcd.Text = lcd.Text + "0";
                newnumber = false;
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (newnumber == false)
            {
                lcd.Text = lcd.Text + "1";



            }

            else if (newnumber == true)
            {

                lcd.Text = "";
                lcd.Text = lcd.Text + "1";
                newnumber = false;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (newnumber == false)
            {
                lcd.Text = lcd.Text + "2";



            }

            else if (newnumber == true)
            {

                lcd.Text = "";
                lcd.Text = lcd.Text + "2";
                newnumber = false;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (newnumber == false)
            {
                lcd.Text = lcd.Text + "3";



            }

            else if (newnumber == true)
            {

                lcd.Text = "";
                lcd.Text = lcd.Text + "3";
                newnumber = false;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (newnumber == false)
            {
                lcd.Text = lcd.Text + "4";



            }

            else if (newnumber == true)
            {

                lcd.Text = "";
                lcd.Text = lcd.Text + "4";
                newnumber = false;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (newnumber == false)
            {
                lcd.Text = lcd.Text + "5";



            }

            else if (newnumber == true)
            {

                lcd.Text = "";
                lcd.Text = lcd.Text + "5";
                newnumber = false;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (newnumber == false)
            {
                lcd.Text = lcd.Text + "6";



            }

            else if (newnumber == true)
            {

                lcd.Text = "";
                lcd.Text = lcd.Text + "6";
                newnumber = false;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (newnumber == false)
            {
                lcd.Text = lcd.Text + "7";



            }

            else if (newnumber == true)
            {

                lcd.Text = "";
                lcd.Text = lcd.Text + "7";
                newnumber = false;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (newnumber == false)
            {
                lcd.Text = lcd.Text + "8";



            }

            else if (newnumber == true)
            {

                lcd.Text = "";
                lcd.Text = lcd.Text + "8";
                newnumber = false;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (newnumber == false)
            {
                lcd.Text = lcd.Text + "9";



            }

            else if (newnumber == true)
            {

                lcd.Text = "";
                lcd.Text = lcd.Text + "9";
                newnumber = false;
            }
        }

        private void btnac_Click(object sender, EventArgs e)
        {
            lcd.Text = "0";
            lblsign.Text = "";
            newnumber = true;
            num1 = 0;
            num2 = 0;
            result = 0;
            sign = 1;
            checkpoint = false;

        }

        private void btnradical_Click(object sender, EventArgs e)
        {

            if (lcd.Text != "")
            {
                result = Math.Sqrt(Convert.ToDouble(lcd.Text));
                lcd.Text = result.ToString();
            }
        }
        private void btnplus_Click(object sender, EventArgs e)
        {
            if(lcd.Text == "")
            {
                op = "+";

            }

            else if(lcd.Text != "")

            {
                num1 = sign * Convert.ToDouble(lcd.Text);

                op = "+";

                lcd.Text = "";
                sign = +1;
                lblsign.Text = "";
                checkpoint = false;
                newnumber = true;


            }

            

        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (lcd.Text == "")
            {
                op = "-";

            }

            else if (lcd.Text != "")

            {
                num1 = sign * Convert.ToDouble(lcd.Text);

                op = "-";

                lcd.Text = "";
                sign = +1;
                lblsign.Text = "";
                checkpoint = false;
                newnumber = true;



            }


            }

        private void btnmultiple_Click(object sender, EventArgs e)
        {

            if (lcd.Text == "")
            {
                op = "*";

            }

            else if (lcd.Text != "")

            {


                num1 = sign * Convert.ToDouble(lcd.Text);

                op = "*";

                lcd.Text = "";
                sign = +1;
                lblsign.Text = "";
                checkpoint = false;
                newnumber = true;
            }
        }

        private void btndivision_Click(object sender, EventArgs e)
        {

            if (lcd.Text == "")
            {
                op = "/";

            }

            else if (lcd.Text != "")

            {
                num1 = sign * Convert.ToDouble(lcd.Text);

                op = "/";

                lcd.Text = "";
                sign = +1;
                lblsign.Text = "";
                checkpoint = false;
                newnumber = true;



            }
        }

        private void btnequal_Click(object sender, EventArgs e)
        {

            if (lcd.Text != "")

            {
                num2 = sign * Convert.ToDouble(lcd.Text);

                switch (op)
                {
                    case "+":
                        result = num1 + num2;

                        break;
                    case "-":
                        result = num1 - num2;

                        break;

                    case "*":
                        result = num1 * num2;

                        break;
                    case "/":
                        result = num1 / num2;

                        break;

                }

                if (result < 0)
                {
                    sign = -1;
                    result = sign * result;
                    lblsign.Text = "-";
                }
                else if (result > 0)
                {
                    sign = 1;
                    result = sign * result;
                    lblsign.Text = "";

                }

                lcd.Text = result.ToString();
                checkpoint = false;


            }
        }

        private void btnmplus_Click(object sender, EventArgs e)
        {
            lblm.Text = "M";

            if(lcd.Text == "")
            {
                op = "+";
           
            }

            else if(op!="")

            {
                switch (op)
                {
                    case "+":
                        resultm = num1 + (sign * Convert.ToDouble(lcd.Text));

                        break;
                    case "-":
                        resultm = num1 - (sign * Convert.ToDouble(lcd.Text));

                        break;

                    case "*":
                        resultm = num1 * (sign * Convert.ToDouble(lcd.Text));

                        break;
                    case "/":
                        resultm = num1 / (sign * Convert.ToDouble(lcd.Text));

                        break;

                }

                mplus = mplus + resultm;
                lcd.Text = "";
                sign = +1;
                lblsign.Text = "";
                checkpoint = false;
                newnumber = true;





            }


            else

            {
                mplus = mplus + sign * Convert.ToDouble(lcd.Text);

                lcd.Text = "";
                sign = +1;

                lblsign.Text = "";

                checkpoint = false;
                newnumber = true;



            }

            op = "";



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnmminus_Click(object sender, EventArgs e)
        {
            lblm.Text = "M";

            if (lcd.Text == "")
            {
                op = "-";

            }

            else if (op != "")

            {
                switch (op)
                {
                    case "+":
                        resultm = num1 + (sign * Convert.ToDouble(lcd.Text));

                        break;
                    case "-":
                        resultm = num1 - (sign * Convert.ToDouble(lcd.Text));

                        break;

                    case "*":
                        resultm = num1 * (sign * Convert.ToDouble(lcd.Text));

                        break;
                    case "/":
                        resultm = num1 / (sign * Convert.ToDouble(lcd.Text));

                        break;

                }

                mminus = mminus - resultm;
                lcd.Text = "";
                sign = +1;
                lblsign.Text = "";
                checkpoint = false;
                newnumber = true;





            }


            else

            {
                mminus = mminus - sign * Convert.ToDouble(lcd.Text);

                lcd.Text = "";
                sign = +1;

                lblsign.Text = "";

                checkpoint = false;
                newnumber = true;



            }

            op = "";

        }

        private void btnmr_Click(object sender, EventArgs e)
        {
            newnumber = true;

            resultm = mplus + mminus;

            if(resultm <0)
            {
                sign = -1;

                resultm = sign * resultm;

                lblsign.Text = "-";

                lcd.Text = resultm.ToString();
             }

            else if(resultm > 0)

            {
                sign = 1;

                resultm = sign * resultm;

                lblsign.Text = "";

                lcd.Text = resultm.ToString();


            }

            else if(resultm == 0)

            {

                lcd.Text = "0";
            }
        }
    }
}
