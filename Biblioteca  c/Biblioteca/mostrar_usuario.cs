using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class mostrar_usuario : Form
    {
        public delegate void pasar(string dato);
        public event pasar pasado;
        conexion c = new conexion();
        public string dato;


        public mostrar_usuario()
        {
            InitializeComponent();
        }

        private void BTNMusuario_Click(object sender, EventArgs e)
        {
            DGVmostrarusuario.DataSource = c.BuscarUsuarioPrestamo(TXTMusuario.Text, TXTMapaterno.Text, TXTMamaterno.Text);
        }

        private void DGVmostrarusuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string dato;
            dato = DGVmostrarusuario.Rows[e.RowIndex].Cells[0].Value.ToString();

            pasado(dato);
            this.Close();
        }
    }
}
