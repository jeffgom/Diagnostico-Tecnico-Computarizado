using Inventario.BL;
using Inventario.Modelos;
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
    public partial class Form3 : Form
    {
        FacturaBL _facturaBL;

        public Form3()
        {
            InitializeComponent();

        }
        public void CargarDatos(FacturaBL facturaBL, ClientesBL clientesBL, ProductosBL productosBL)
        {
            _facturaBL = facturaBL;
            listadeFacturaBindingSource.DataSource = facturaBL.ListadeFactura;
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;
            listadeProductosBindingSource.DataSource = productosBL.ListadeProductos;
        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)listadeFacturaBindingSource.Current;
            factura.CalcularFactura();

            listadeFacturaBindingSource.ResetBindings(false);
        }
    }

}
