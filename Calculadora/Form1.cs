using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1, num2, rpta;
        string operacion;
        bool ap = true;
        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void btnRPTA_Click(object sender, EventArgs e)
        {
        
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            num1 = double.Parse(txtNum.Text);
            txtNum.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            num1 = double.Parse(txtNum.Text);
            txtNum.Text = "";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            num1 = double.Parse(txtNum.Text);
            txtNum.Text = "";
                    }

        private void btndivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            num1 = double.Parse(txtNum.Text);
            txtNum.Text = "";
            
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtNum.Text);
            switch (operacion)
            {
                case "+":
                    rpta = num1 + num2;
                    break;
                case "-":
                    rpta = num1 - num2;
                    break;
                case "*":
                    rpta = num1 * num2;
                    break;
                case "/":
                    rpta = num1 / num2;
                    break;                    
            }
            txtNum.Text = "";
            txtNum.Text = Convert.ToString(rpta);
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                txtNum.Text = btn1.Text;
            }
            else
                if (txtNum.Text.Length<=15) txtNum.Text = txtNum.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                txtNum.Text = btn2.Text;
            }
            else if (txtNum.Text.Length <= 15) txtNum.Text = txtNum.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                txtNum.Text = btn3.Text;
            }
            else if (txtNum.Text.Length<=15) txtNum.Text = txtNum.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                txtNum.Text = btn4.Text;
            }
            else if (txtNum.Text.Length <= 15) txtNum.Text = txtNum.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                txtNum.Text = btn5.Text;
            }
            else if (txtNum.Text.Length <= 15) txtNum.Text = txtNum.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                txtNum.Text = btn6.Text;
            }
            else if (txtNum.Text.Length <= 15) txtNum.Text = txtNum.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                txtNum.Text = btn7.Text;
            }
            else if (txtNum.Text.Length <= 15) txtNum.Text = txtNum.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                txtNum.Text = btn8.Text;
            }
            else if (txtNum.Text.Length <= 15) txtNum.Text = txtNum.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                txtNum.Text = btn9.Text;
            }
            else if (txtNum.Text.Length <= 15) txtNum.Text = txtNum.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                txtNum.Text = btn0.Text;
            }
            else if (txtNum.Text.Length <= 15) txtNum.Text = txtNum.Text + btn0.Text;
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "") { txtNum.Text = "0."; ap = false;}
            if (ap == true)
            {
                txtNum.Text = txtNum.Text + btnPunto.Text;
                ap = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
        }

        private void txtNum_TextChanged(object sender, EventArgs e)

        { 
           
        }
     
        
    }
}
