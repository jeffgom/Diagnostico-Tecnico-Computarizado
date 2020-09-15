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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            PersonalizarDiseño();
        }

        private void PersonalizarDiseño()
        {
            panelsubmenuventas.Visible = false;
            panelreporteI.Visible = false;
            panelreportes.Visible = false;
        }

        private void OcultarSubMenu()
        {

            if (panelsubmenuventas.Visible == true)
                panelsubmenuventas.Visible = false;
            if (panelreporteI.Visible == true)
                panelreporteI.Visible = false;
            if (panelreportes.Visible == true)
                panelreportes.Visible = false;

        }

        private void MostrarSubMenu(Panel submenu)
        {

            if (submenu.Visible == false)
            {
                OcultarSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelsubmenuventas);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbriHijos(new Form1());
            //formProductos.MdiParent = this;

            //formProductos.Show();


            OcultarSubMenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbriHijos(new Form2());


            OcultarSubMenu();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {




            OcultarSubMenu();
        }

        private void btnVen_Click(object sender, EventArgs e)
        {




            OcultarSubMenu();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelreporteI);
        }

        private void btnRCliente_Click(object sender, EventArgs e)
        {




            OcultarSubMenu();
        }

        private void btnRProducto_Click(object sender, EventArgs e)
        {




            OcultarSubMenu();
        }

        private void btnRVenta_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelreportes);
        }

        private void btnRC_Click(object sender, EventArgs e)
        {




            OcultarSubMenu();
        }

        private void btnRP_Click(object sender, EventArgs e)
        {




            OcultarSubMenu();
        }

        private void btnRT_Click(object sender, EventArgs e)
        {




            OcultarSubMenu();
        }

        private Form formactivo = null;
        private void AbriHijos(Form Formhijo)
        {

            if (formactivo != null)
                formactivo.Close();
            formactivo = Formhijo;
            Formhijo.TopLevel = false;
            Formhijo.FormBorderStyle = FormBorderStyle.None;
            Formhijo.Dock = DockStyle.Fill;
            panelformhijo.Controls.Add(Formhijo);
            panelformhijo.Tag = Formhijo;
            Formhijo.BringToFront();
            Formhijo.Show();

        }

    }
}
