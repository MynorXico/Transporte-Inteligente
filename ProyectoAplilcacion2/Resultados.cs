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
    public partial class Resultados : Form
    {
        Servicio s;
        public Resultados(Servicio s)
        {
            this.s = s;
            InitializeComponent();
            FillGrid(s);
        }

        public void FillGrid(Servicio s)
        {
            for(int i = 0; i < s.TablaResultado.GetLength(0); i++)
            {
                object[] rowValues = {($"{s.Tratos[i].Fabrica} y {s.Tratos[i].Proveedor}"), s.TablaResultado[i, 0], s.TablaResultado[i,1], s.TablaResultado[i,2]};
                dgvResultados.Rows.Add(rowValues);
            }
            object[] totalRow = {"","","TOTAL", s.suma};
            dgvResultados.Rows.Add(totalRow);
        }
    }
}
