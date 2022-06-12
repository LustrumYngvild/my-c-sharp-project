using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double ilkislem,ikinciislem,sonuc;
        string islem;
        private void btn0_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpanel.TextLength!=0)
            {
                ilkislem = Convert.ToDouble(txtpanel.Text);
                txtpanel.Clear();
                label1.Text = ilkislem.ToString() + " +";
                islem = "+";
            }
            else if (islem != "")
            {
                label1.Text = ilkislem.ToString() + " +";
                islem = "+";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtpanel.TextLength != 0)
            {
                ilkislem = Convert.ToDouble(txtpanel.Text);
                txtpanel.Clear();
                label1.Text = ilkislem.ToString() + " -";
                islem = "-";
            }
            else if (islem!="")
            {
                label1.Text = ilkislem.ToString() + " -";
                islem = "-";
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (txtpanel.TextLength != 0)
            {
                ilkislem = Convert.ToDouble(txtpanel.Text);
                txtpanel.Clear();
                label1.Text = ilkislem.ToString() + " *";
                islem = "*";
            }
            else if (islem != "")
            {
                label1.Text = ilkislem.ToString() + " *";
                islem = "*";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtpanel.TextLength!=0)
            {
                txtpanel.Text = txtpanel.Text + ",";
            }
            else 
            {
                txtpanel.Text = txtpanel.Text + "0,";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtpanel.TextLength!=0)
            {
                txtpanel.Text = txtpanel.Text.Substring(0, txtpanel.Text.Length - 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            ilkislem = 0;
            ikinciislem = 0;
            islem = "";
            txtpanel.Text = "";
            sonuc = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtpanel.TextLength != 0)
            {
                ilkislem = Convert.ToDouble(txtpanel.Text);
                txtpanel.Clear();
                label1.Text = ilkislem.ToString() + " /";
                islem = "/";
            }
            else if (islem != "")
            {
                label1.Text = ilkislem.ToString() + " /";
                islem = "/";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = ilkislem.ToString();
            if (txtpanel.Text.Length!=0)
            {
                ikinciislem = Convert.ToDouble(txtpanel.Text);
                switch (islem)
                {
                    case "+":sonuc = ilkislem + ikinciislem;txtpanel.Text = sonuc.ToString();break;
                    case "-":sonuc = ilkislem - ikinciislem;txtpanel.Text = sonuc.ToString();break;
                    case "*":sonuc = ilkislem * ikinciislem;txtpanel.Text = sonuc.ToString();break;
                    case "/":sonuc = ilkislem / ikinciislem;txtpanel.Text = sonuc.ToString();break;
                    default:break;         
                }
            }
            label1.Text = "";
            ilkislem = 0;
            ikinciislem=0;
            sonuc = 0;
        }
    }
}
