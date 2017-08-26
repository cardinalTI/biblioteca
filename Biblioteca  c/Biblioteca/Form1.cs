using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        conexion conexion = new conexion();
       
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
             conexion.logear(this.TXBusuario.Text,this.TXBpass.Text);
        }
    }
}
