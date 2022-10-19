using quieropizzaBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quieropizza.win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var productosBL = new productosBL();
            var listadeproductos = productosBL.Obtenerproductos();

            foreach (var productos in listadeproductos)
            {
                ;
            }

            {
                MessageBox.Show(producto.Descripcion);
            }
        }
    }
}
