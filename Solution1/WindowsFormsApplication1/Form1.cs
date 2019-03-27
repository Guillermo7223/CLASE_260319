using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operaciones;

namespace WindowsFormsApplication1
{
    public partial class frnOperaciones : Form
    {
        Operacion ingreso;
        public frnOperaciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frnOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click_1(object sender, EventArgs e)
        {
            ingreso = new Operacion();
            ingreso.V1 = double.Parse(txtValA.Text);
            ingreso.V2 = double.Parse(txtValB.Text);
            lblResultado.Text = ingreso.CalcularS().ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            ingreso = new Operacion();
            ingreso.V1 = double.Parse(txtValA.Text);
            ingreso.V2 = double.Parse(txtValB.Text);
            lblResultado.Text = ingreso.CalcularR().ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            ingreso = new Operacion();
            ingreso.V1 = double.Parse(txtValA.Text);
            ingreso.V2 = double.Parse(txtValB.Text);
            lblResultado.Text = ingreso.CalcularM().ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            ingreso = new Operacion();
            ingreso.V1 = double.Parse(txtValA.Text);
            ingreso.V2 = double.Parse(txtValB.Text);
            if (ingreso.V2 == 0)
            {
                lblResultado.Text = "No se puede Dividir entre 0";
            }
            else
            {
                lblResultado.Text = ingreso.CalcularD().ToString();
            }
        }
    }
}
