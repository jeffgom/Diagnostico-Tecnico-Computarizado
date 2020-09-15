using Inventario.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.BL
{
    public class ProductosBL
    {
        public BindingList<Producto> ListadeProductos { get; set; }

        public ProductosBL()
        {
            ListadeProductos = new BindingList<Producto>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var tipo1 = new Tipo(001, " Electrica ", " Americana ");
            var tipo2 = new Tipo(010, " Mecanica ", " Europea ");
            var tipo3 = new Tipo(100, " Electrica ", " China ");

            var producto1 = new Producto(001, "Arbol de Lebas", 1200.00, DateTime.Now, tipo2);
            var producto2 = new Producto(010, "Sensor Sigueñas", 1500.00, DateTime.Now, tipo1);
            var producto3 = new Producto(100, "Luces Neon", 200.00, DateTime.Now, tipo3);

            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);
        }

    }
}
