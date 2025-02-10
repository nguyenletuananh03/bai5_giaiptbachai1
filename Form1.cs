using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5_giaiptbachai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            int a = Convert .ToInt32(txtA.Text);
            int b = Convert .ToInt32(txtB.Text);
            int c = Convert .ToInt32(txtC.Text);
            double delta, x1, x2;
            if (a == 0)
            {
                if (b == 0){
                    if (c !=0)
                    {
                        lblKQ.Text = "pt vô nghiệm ";
                    }
                    else
                    {
                        lblKQ.Text = "pt vô sô nghiệm";
                    }  
                }else
                {
                    x1 = x2 = (double)-c / b;
                    lblKQ.Text = "pt có nghiệm x =" + x1;
                }
            }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    lblKQ.Text = "pt vô nghiệm ";
                }
                else if (delta == 0) { 
                    x1 = x2 =-b / (2 * a);
                    lblKQ.Text = "pt co nghiệm kép x1 = x2 =" + x1;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    lblKQ.Text = "pt co 2 nghiem phan biet\nx1 = " + "\nx2 = " + x2;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtA.Text = tbA.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            txtC.Text = tbC.Value.ToString();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            txtB.Text = tbB.Value.ToString();
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
