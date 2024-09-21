using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OperadoresLogicos
{
    public partial class frmOperadoresLogicos : Form
    {
        public frmOperadoresLogicos()
        {
            InitializeComponent();
        }

        int numero1, numero2;
        bool resultado;

        private void frmOperadoresLogicos_Load(object sender, EventArgs e)
        {

        }

        private void btnY_Click(object sender, EventArgs e)
        {
            OperadorY();
        }

        private void Asignar()
        {
            numero1 = Convert.ToInt32(txtnumero1.Text);
            numero2 = Convert.ToInt32(txtnumero2.Text);
        }

        private void btnO_Click(object sender, EventArgs e)
        {

        }

        private void OperadorO()
        {
            Asignar();

            //Debe cumplir una condicion para ser verdadero
            if (numero1 > 5 || numero2 < 10 )
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            lblresultado.Text = resultado.ToString();
        }

        private void OperadorY()
        {
            Asignar();


            if (numero1 > 5 && numero2 < 10)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            lblresultado.Text = resultado.ToString();
        }
        


    }
}
