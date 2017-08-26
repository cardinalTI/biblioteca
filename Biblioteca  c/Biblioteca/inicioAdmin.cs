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
    public partial class inicioAdmin : Form
    {
        public inicioAdmin(string nombre)
        {
            InitializeComponent();
            label1.Text = nombre;
        }
    }
}
