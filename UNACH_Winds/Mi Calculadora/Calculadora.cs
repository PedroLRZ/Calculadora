using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mi_Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        double primero;
        double segundo;
        double resultado;
        string operacion;                         

        private void Form1_Load(object sender, EventArgs e)
        {
            string sMensaje = "¿Quieres iniciar la aplicación?";
            string sTitulo = "Bienvenid@";

            MessageBoxButtons mBotones = MessageBoxButtons.YesNo;
            DialogResult sResultado;

            sResultado = MessageBox.Show(sMensaje, sTitulo, mBotones, (MessageBoxIcon.Information));

            if (sResultado == System.Windows.Forms.DialogResult.No)
            {
                this.Close();
            }
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            txtpan.Text = txtpan.Text + "2";
        }

        private void btn0_Click_1(object sender, EventArgs e)
        {
            txtpan.Text = txtpan.Text + "0";
        }

        private void btnpunt_Click_1(object sender, EventArgs e)
        {
            txtpan.Text = txtpan.Text + ".";
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            txtpan.Text = txtpan.Text + "1";
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            txtpan.Text = txtpan.Text + "3";
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            txtpan.Text = txtpan.Text + "4";
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            txtpan.Text = txtpan.Text + "5";
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            txtpan.Text = txtpan.Text + "6";
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            txtpan.Text = txtpan.Text + "7";
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            txtpan.Text = txtpan.Text + "8";
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            txtpan.Text = txtpan.Text + "9";
        }

        private void btnmas_Click_1(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(txtpan.Text);
            txtpan.Clear();
            txtpan.Focus();
        }

        private void btnmen_Click_1(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(txtpan.Text);
            txtpan.Clear();
            txtpan.Focus();
        }

        private void btnmul_Click_1(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(txtpan.Text);
            txtpan.Clear();
            txtpan.Focus();
        }

        private void btndiv_Click_1(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(txtpan.Text);
            txtpan.Clear();
            txtpan.Focus();
        }

        private void btnig_Click_1(object sender, EventArgs e)
        {
            try
            {
                segundo = double.Parse(txtpan.Text);
            }
            catch when (txtpan.Text == "")
            {
                return;
            }

            switch (operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    txtpan.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    txtpan.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = primero * segundo;
                    txtpan.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primero / segundo;
                    txtpan.Text = resultado.ToString();
                    break;
            }
        }

        private void btnce_Click_1(object sender, EventArgs e)
        {
            txtpan.Clear();
            txtpan.Focus();
        }

        private void btnraiz_Click_1(object sender, EventArgs e)
        {
            operacion = "Raiz";
            primero = double.Parse(txtpan.Text);
            resultado = primero;
            txtpan.Text = Math.Sqrt(primero).ToString();
        }

        private void txtpan_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NumerosDecimales(e);
        }
    }
}
