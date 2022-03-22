using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCalculator
{
    public partial class mainForm : Form
    {
        //private string initial;
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dsplyBox.Text == "0")
            {
                this.dsplyBox.Text = this.button1.Text;
            }
            else
            {
                this.dsplyBox.Text += this.button1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dsplyBox.Text == "0")
            {
                this.dsplyBox.Text = this.button2.Text;
            }
            else
            {
                this.dsplyBox.Text += this.button2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.dsplyBox.Text == "0")
            {
                this.dsplyBox.Text = this.button3.Text;
            }
            else
            {
                this.dsplyBox.Text += this.button3.Text;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.dsplyBox.Text == "0")
            {
                this.dsplyBox.Text = this.button4.Text;
            }
            else
            {
                this.dsplyBox.Text += this.button4.Text;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.dsplyBox.Text == "0")
            {
                this.dsplyBox.Text = this.button5.Text;
            }
            else
            {
                this.dsplyBox.Text += this.button5.Text;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.dsplyBox.Text == "0")
            {
                this.dsplyBox.Text = this.button6.Text;
            }
            else
            {
                this.dsplyBox.Text += this.button6.Text;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.dsplyBox.Text == "0")
            {
                this.dsplyBox.Text = this.button7.Text;
            }
            else
            {
                this.dsplyBox.Text += this.button7.Text;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.dsplyBox.Text == "0")
            {
                this.dsplyBox.Text = this.button8.Text;
            }
            else
            {
                this.dsplyBox.Text += this.button8.Text;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.dsplyBox.Text == "0")
            {
                this.dsplyBox.Text = this.button9.Text;
            }
            else
            {
                this.dsplyBox.Text += this.button9.Text;
            }

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (this.dsplyBox.Text == "0")
            {
                this.dsplyBox.Text = "0";
            }
            else
            {
                this.dsplyBox.Text += this.btnZero.Text;
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (this.dsplyBox.Text == "0")
            {
                this.dsplyBox.Text = "0";
            }
            else
            {
                if (this.dsplyBox.Text.Contains("."))
                {
                    this.dsplyBox.Text = this.dsplyBox.Text;
                }
                else
                {
                    this.dsplyBox.Text += this.btnDot.Text;
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            
            if (this.dsplyBox.Text=="0")
            {
                this.txtSign.Text = "+";
            }
            else
            {
                if(this.txtSign.Text == "+")
                {
                    double rslt = Convert.ToDouble(this.txtValue.Text) + Convert.ToDouble(this.dsplyBox.Text);
                    this.txtValue.Text = rslt.ToString();
                    this.txtSign.Text = "+";
                    this.dsplyBox.Text = "0";
                }
                else if(this.txtSign.Text == "-")
                {
                    double rslt = Convert.ToDouble(this.txtValue.Text) - Convert.ToDouble(this.dsplyBox.Text);
                    this.txtValue.Text = rslt.ToString();
                    this.txtSign.Text = "+";
                    this.dsplyBox.Text = "0";
                }
                else if (this.txtSign.Text == "*")
                {
                    double rslt = Convert.ToDouble(this.txtValue.Text) * Convert.ToDouble(this.dsplyBox.Text);
                    this.txtValue.Text = rslt.ToString();
                    this.txtSign.Text = "+";
                    this.dsplyBox.Text = "0";
                }
                else if (this.txtSign.Text == "/")
                {
                    double rslt = Convert.ToDouble(this.txtValue.Text) / Convert.ToDouble(this.dsplyBox.Text);
                    this.txtValue.Text = rslt.ToString();
                    this.txtSign.Text = "+";
                    this.dsplyBox.Text = "0";
                }
                else
                {
                    double rslt = Convert.ToDouble(this.txtValue.Text) + Convert.ToDouble(this.dsplyBox.Text);
                    this.txtValue.Text = rslt.ToString();
                    this.txtSign.Text = "+";
                    this.dsplyBox.Text = "0";
                }
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (this.dsplyBox.Text == "0")
            {
                this.txtSign.Text = "-";
            }
            else
            {
                if (this.txtSign.Text == "+")
                {
                    double rslt = Convert.ToDouble(this.txtValue.Text) + Convert.ToDouble(this.dsplyBox.Text);
                    this.txtValue.Text = rslt.ToString();
                    this.txtSign.Text = "-";
                    this.dsplyBox.Text = "0";
                }
                else if (this.txtSign.Text == "-")
                {
                    double rslt = Convert.ToDouble(this.txtValue.Text) - Convert.ToDouble(this.dsplyBox.Text);
                    this.txtValue.Text = rslt.ToString();
                    this.txtSign.Text = "-";
                    this.dsplyBox.Text = "0";
                }
                else if (this.txtSign.Text == "*")
                {
                    double rslt = Convert.ToDouble(this.txtValue.Text) * Convert.ToDouble(this.dsplyBox.Text);
                    this.txtValue.Text = rslt.ToString();
                    this.txtSign.Text = "-";
                    this.dsplyBox.Text = "0";
                }
                else if (this.txtSign.Text == "/")
                {
                    double rslt = Convert.ToDouble(this.txtValue.Text) / Convert.ToDouble(this.dsplyBox.Text);
                    this.txtValue.Text = rslt.ToString();
                    this.txtSign.Text = "-";
                    this.dsplyBox.Text = "0";
                }
                else
                {
                    if(this.txtValue.Text=="0")
                    {
                        this.txtValue.Text = this.dsplyBox.Text;
                        this.txtSign.Text = "-";
                        this.dsplyBox.Text = "0";
                    }
                    else 
                    {
                        double rslt = Convert.ToDouble(this.txtValue.Text) - Convert.ToDouble(this.dsplyBox.Text);
                        this.txtValue.Text = rslt.ToString();
                        this.txtSign.Text = "-";
                        this.dsplyBox.Text = "0";
                    }
                    
                }
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (this.dsplyBox.Text == "0")
            {
                this.txtSign.Text = "*";
            }
            else
            {
                if (this.txtSign.Text == "+")
                {
                    double rslt = Convert.ToDouble(this.txtValue.Text) + Convert.ToDouble(this.dsplyBox.Text);
                    this.txtValue.Text = rslt.ToString();
                    this.txtSign.Text = "*";
                    this.dsplyBox.Text = "0";
                }
                else if (this.txtSign.Text == "-")
                {
                    double rslt = Convert.ToDouble(this.txtValue.Text) - Convert.ToDouble(this.dsplyBox.Text);
                    this.txtValue.Text = rslt.ToString();
                    this.txtSign.Text = "*";
                    this.dsplyBox.Text = "0";
                }
                else if (this.txtSign.Text == "*")
                {
                    double rslt = Convert.ToDouble(this.txtValue.Text) * Convert.ToDouble(this.dsplyBox.Text);
                    this.txtValue.Text = rslt.ToString();
                    this.txtSign.Text = "*";
                    this.dsplyBox.Text = "0";
                }
                else if (this.txtSign.Text == "/")
                {
                    double rslt = Convert.ToDouble(this.txtValue.Text) / Convert.ToDouble(this.dsplyBox.Text);
                    this.txtValue.Text = rslt.ToString();
                    this.txtSign.Text = "*";
                    this.dsplyBox.Text = "0";
                }
                else
                {
                    if (this.txtValue.Text == "0")
                    {
                        this.txtValue.Text = this.dsplyBox.Text;
                        this.txtSign.Text = "*";
                        this.dsplyBox.Text = "0";
                    }
                    else
                    {
                        double rslt = Convert.ToDouble(this.txtValue.Text) * Convert.ToDouble(this.dsplyBox.Text);
                        this.txtValue.Text = rslt.ToString();
                        this.txtSign.Text = "*";
                        this.dsplyBox.Text = "0";
                    }
                }
            }

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (this.dsplyBox.Text == "0")
            {
                this.txtSign.Text = "/";
            }
            else
            {
                if (this.txtSign.Text == "+")
                {
                    double rslt = Convert.ToDouble(this.txtValue.Text) + Convert.ToDouble(this.dsplyBox.Text);
                    this.txtValue.Text = rslt.ToString();
                    this.txtSign.Text = "/";
                    this.dsplyBox.Text = "0";
                }
                else if (this.txtSign.Text == "-")
                {
                    double rslt = Convert.ToDouble(this.txtValue.Text) - Convert.ToDouble(this.dsplyBox.Text);
                    this.txtValue.Text = rslt.ToString();
                    this.txtSign.Text = "/";
                    this.dsplyBox.Text = "0";
                }
                else if (this.txtSign.Text == "*")
                {
                    double rslt = Convert.ToDouble(this.txtValue.Text) * Convert.ToDouble(this.dsplyBox.Text);
                    this.txtValue.Text = rslt.ToString();
                    this.txtSign.Text = "/";
                    this.dsplyBox.Text = "0";
                }
                else if (this.txtSign.Text == "/")
                {
                    double rslt = Convert.ToDouble(this.txtValue.Text) / Convert.ToDouble(this.dsplyBox.Text);
                    this.txtValue.Text = rslt.ToString();
                    this.txtSign.Text = "/";
                    this.dsplyBox.Text = "0";
                }
                else
                {
                    if (this.txtValue.Text == "0")
                    {
                        this.txtValue.Text = this.dsplyBox.Text;
                        this.txtSign.Text = "/";
                        this.dsplyBox.Text = "0";
                    }
                    else
                    {
                        double rslt = Convert.ToDouble(this.txtValue.Text) / Convert.ToDouble(this.dsplyBox.Text);
                        this.txtValue.Text = rslt.ToString();
                        this.txtSign.Text = "/";
                        this.dsplyBox.Text = "0";
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(this.dsplyBox.Text=="0" )
            { 
            }
            else if(this.dsplyBox.Text.Length > 0)
            {
                if (this.dsplyBox.Text.Length==1) 
                {
                    this.dsplyBox.Text = "0";
                 }
                else
                {
                    int length = this.dsplyBox.Text.Length;
                    this.dsplyBox.Text = this.dsplyBox.Text.Substring(0, length - 1);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.dsplyBox.Text = "0";
            this.txtSign.Text = "0";
            this.txtValue.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.txtSign.Text == "+")
            {
                double rslt = Convert.ToDouble(this.txtValue.Text) + Convert.ToDouble(this.dsplyBox.Text);
                this.txtValue.Text = rslt.ToString();
                this.txtSign.Text = "0";
                this.dsplyBox.Text = "0";
            }
            else if (this.txtSign.Text == "-")
            {
                double rslt = Convert.ToDouble(this.txtValue.Text) - Convert.ToDouble(this.dsplyBox.Text);
                this.txtValue.Text = rslt.ToString();
                this.txtSign.Text = "0";
                this.dsplyBox.Text = "0";
            }
            else if (this.txtSign.Text == "*")
            {
                double rslt = Convert.ToDouble(this.txtValue.Text) * Convert.ToDouble(this.dsplyBox.Text);
                this.txtValue.Text = rslt.ToString();
                this.txtSign.Text = "0";
                this.dsplyBox.Text = "0";
            }
            else if (this.txtSign.Text == "/")
            {
                double rslt = Convert.ToDouble(this.txtValue.Text) / Convert.ToDouble(this.dsplyBox.Text);
                this.txtValue.Text = rslt.ToString();
                this.txtSign.Text = "0";
                this.dsplyBox.Text = "0";
            }

        }
    }
}
