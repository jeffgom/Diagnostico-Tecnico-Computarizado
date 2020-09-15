using Inventario.BL;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


        }

        public void CargarDatos(ClientesBL clientesbl, DireccionesBL direccionBL)
        {

            listadeClientesBindingSource.DataSource = clientesbl.ListadeClientes;


            listadeDireccionesBindingSource.DataSource = direccionBL.ListadeDirecciones;
        }

    }
}
