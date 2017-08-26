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
    public partial class mostrar_libro : Form
    {
        public delegate void pasarl(string dato);
        public event pasarl pasadol;
        metodos_libros ML = new metodos_libros();
        public mostrar_libro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVMlibros.DataSource = ML.Buscarlibro(CBMMlibro.Text, TXBMlibro.Text);
        }

        private void DGVMlibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string dato;
            dato = DGVMlibros.Rows[e.RowIndex].Cells[0].Value.ToString();

            pasadol(dato);
            this.Close();
        }
    }
}
