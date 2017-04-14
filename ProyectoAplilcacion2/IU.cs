using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ProyectoAplicacion2
{
    public partial class Form1 : Form
    {
        Servicio s;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {

        }

        private void BtnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            TextRutaArchivo.Enabled = true;
            TextRutaArchivo.Text = ofd.FileName;
            TextRutaArchivo.Enabled = false;
            if (!File.Exists(ofd.FileName))
            {
                TextRutaArchivo.Text = "";
                return;
            }

            try
            {
                new Resultados(new Servicio(ofd.FileName)).ShowDialog();
            }catch(Exception i)
            {
                MessageBox.Show("El Formato del archivo no es el correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIngresoDatos_Click(object sender, EventArgs e)
        {
            int numeroFabricas, numeroProveedores;
            try
            {
                numeroFabricas = int.Parse(txtFabricas.Text);
                numeroProveedores = int.Parse(txtProveedores.Text);
                if(numeroFabricas <= 0 || numeroProveedores <= 0)
                {
                    MessageBox.Show("Ingrese valores válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese valores válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<Fabrica> Fabricas = new List<Fabrica>();
            List<Proveedor> Proveedores = new List<Proveedor>();
            
            for(int i = 0; i < numeroFabricas; i++)
            {
                Fabrica f = new Fabrica();
                new IngresoDatos($"Fabrica {i+1}").ObtenerDatos(ref f.Nombre, ref f.CantidadSolicitud);
                Fabricas.Add(f);
            }
            for(int i = 0; i < numeroProveedores; i++)
            {
                Proveedor p = new Proveedor();
                new IngresoDatos($"Proveedor {i+1}").ObtenerDatos(ref p.Nombre, ref p.ElementosSolicitados);
                Proveedores.Add(p);
            }
            List<Trato> Tratos = new List<Trato>();
            foreach(Fabrica f in Fabricas)
            {
                foreach(Proveedor p in Proveedores)
                {
                    Trato t = new Trato();
                    t.Fabrica = f.Nombre;
                    t.Proveedor = p.Nombre;
                    Tratos.Add(t);
                }
            }
            List<double> Precios = new List<double>();
            foreach(Trato t in Tratos)
            {
                Precios.Add(1);
            }
            new Resultados(new Servicio(Fabricas, Proveedores, Tratos, Precios)).ShowDialog();


        }
    }
}
