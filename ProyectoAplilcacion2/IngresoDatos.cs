using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAplicacion2
{
    public partial class IngresoDatos : Form
    {
        string Nombre="*";
        int Cantidad=-1;
        public IngresoDatos(string tipo)
        {
            InitializeComponent();

            lblNombre.Text = lblNombre.Text + tipo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nombre = textBox1.Text;
            int.TryParse(textBox2.Text, out Cantidad);
            if (!(Nombre == "*" || Cantidad <= 0))
                this.Close();
            else
                MessageBox.Show("Ingrese valores válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal void ObtenerDatos(ref string unNombre, ref int unaCantidad)
        {
            this.ShowDialog();
            unNombre = Nombre;
            unaCantidad = Cantidad;
        }
    }
}
