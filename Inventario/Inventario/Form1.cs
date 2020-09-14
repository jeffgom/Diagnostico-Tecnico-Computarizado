using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var producto1 = new Producto();
            producto1.Id = 001;
            producto1.Descripcion = "sepa dios";
            producto1.Precio = 1500.00;
            producto1.FechaC = DateTime.Now;

            MessageBox.Show(producto1.Id+ "" + "" + producto1.Descripcion + "" + producto1.Precio + "" + producto1.FechaC);
        }
    }
}
