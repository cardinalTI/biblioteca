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
    public partial class inicio : Form
    {
        conexion c = new conexion();
        mostrar_usuario mu = new mostrar_usuario();
        mostrar_libro mol = new mostrar_libro();
        metodos_libros ML = new metodos_libros();
        metodos_prestamo mp = new metodos_prestamo();
        public inicio()
        {
            InitializeComponent();
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = DTPingreso.Value.Date;

            if (c.ValidarUsuario(TXBnombre.Text, TXBap.Text, TXBam.Text) == 0)
            {
                c.InsertarUsuario(TXBnombre.Text,TXBap.Text,TXBam.Text,TXBdirec.Text ,TXBtel.Text,TXBedad.Text,fecha  );
               
            }
            else
            {
                MessageBox.Show("Esta persona ya se encuentra registrada");
            }

            TXBnombre.Clear();TXBap.Clear();TXBam.Clear();TXBdirec.Clear();TXBtel.Clear();TXBedad.Clear();DTPingreso.Refresh();
        }

        private void BTNbuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.BuscarUsuario(TXBbnombre.Text ,TXBbap.Text,TXBbam.Text );
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TXBidpersona.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TXBnombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TXBap.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TXBam.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TXBdirec.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TXBtel.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TXBedad.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            TXBstatus.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

        }

        private void BTNmodificar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DTPingreso.Value.Date;
            c.ModificarUsuario(Convert.ToInt32(TXBidpersona.Text) ,TXBnombre.Text, TXBap.Text, TXBam.Text, TXBdirec.Text, TXBtel.Text, TXBedad.Text, fecha,CBXstatus.Text );
        }

        private void BTNalibro_Click(object sender, EventArgs e)
        {

            if (c.ValidarUsuario(TXBnombrelibro.Text,TXBautorlibro.Text,TXBeditorial.Text) == 0)
            {
                ML.Insertarlibro(TXBnombrelibro.Text,TXBeditorial .Text, CBXgenero.Text ,TXBautorlibro.Text ,TXBidiomalibro.Text,TXByearlibro.Text,TXBpaginaslibro.Text , TXBedicionlibro.Text, Convert.ToInt32(TXBlcantidad.Text));
            }
            else
            {
                MessageBox.Show("Este libro ya se encuentra registrado");
            }
        }

        private void button2BTNmodificarlibro_Click(object sender, EventArgs e)
        {
            ML.Modificarlibro(Convert.ToInt32(TXBidlibro.Text), TXBnombrelibro.Text, TXBeditorial.Text, CBXgenero .Text, TXBautorlibro.Text, TXBidiomalibro.Text, TXByearlibro.Text, TXBpaginaslibro.Text, TXBedicionlibro .Text,TXBlcantidad.Text,CBXstatuslibro.Text);
        }

        private void BTNbuscarlibro_Click(object sender, EventArgs e)
        {
            DGVlibros.DataSource = ML.Buscarlibro(CBXblibro.Text, TXTBlibro.Text);
        }

     

        private void DGVlibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TXBidlibro.Text = DGVlibros.Rows[e.RowIndex].Cells[0].Value.ToString();
            TXBnombrelibro.Text = DGVlibros.Rows[e.RowIndex].Cells[1].Value.ToString();
            TXBeditorial.Text = DGVlibros.Rows[e.RowIndex].Cells[2].Value.ToString();
            CBXgenero.Text = DGVlibros.Rows[e.RowIndex].Cells[3].Value.ToString();
            TXBautorlibro.Text = DGVlibros.Rows[e.RowIndex].Cells[4].Value.ToString();
            TXBidiomalibro.Text = DGVlibros.Rows[e.RowIndex].Cells[5].Value.ToString();
            TXByearlibro.Text = DGVlibros.Rows[e.RowIndex].Cells[6].Value.ToString();
            TXBpaginaslibro.Text = DGVlibros.Rows[e.RowIndex].Cells[7].Value.ToString();
            TXBedicionlibro.Text = DGVlibros.Rows[e.RowIndex].Cells[8].Value.ToString();
            TXBlcantidad.Text = DGVlibros.Rows[e.RowIndex].Cells[9].Value.ToString();
            CBXstatuslibro.Text = DGVlibros.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void BTNPbuscarusuario_Click(object sender, EventArgs e)
        {

            mostrar_usuario mostraru = new mostrar_usuario();
            mostraru.pasado += new mostrar_usuario.pasar(ejecutar);
            mostraru.ShowDialog();

        }

        public void ejecutar(string dato) {

            TXTPnusuario.Text = dato;
        }

        public void ejecutardos(string dato)
        {

            TXTPclibro.Text = dato;
        }

        private void BTNPbuscarlibro_Click(object sender, EventArgs e)
        {
            mostrar_libro mostrarl = new mostrar_libro();
            mostrarl.pasadol += new mostrar_libro.pasarl(ejecutardos);
            mostrarl.ShowDialog();
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void BTNprestamo_Click(object sender, EventArgs e)
        {
            mp.generar_prestamo( TXTPnusuario.Text,TXTPclibro.Text,DTPfprestamo.Text , CBXpestado.Text);
        }

        private void BTNBprestamo_Click(object sender, EventArgs e)
        {
            DGVPrestamo.DataSource = mp.Buscarprestamo(CBXBprestamo.Text, TXTBprestamo.Text);
        }

        private void BTNactualizarprestamo_Click(object sender, EventArgs e)
        {
            mp.ModificarPrestamo(Convert.ToInt32(TXTPcodigo.Text), TXTPnusuario.Text, TXTPclibro.Text,DTPfprestamo.Text,CBXpestado.Text);
        }

        private void DGVPrestamo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           TXTPcodigo.Text = DGVPrestamo.Rows[e.RowIndex].Cells[0].Value.ToString();
           TXTPnusuario.Text = DGVPrestamo.Rows[e.RowIndex].Cells[1].Value.ToString();
           TXTPclibro.Text = DGVPrestamo.Rows[e.RowIndex].Cells[2].Value.ToString();
           
           CBXpestado.Text = DGVPrestamo.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
    }

