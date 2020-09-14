using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Modelos
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int TipoId { get; set; }
        public DateTime FechaC { get; set; }
        public Tipo Tipo { get; set; }

        public Producto(int id, string descripcion, double precio, DateTime fechac, Tipo tipo)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
            fechac = DateTime.Now;
            Tipo = tipo;
            TipoId = tipo.Id; 
        }

    }
}
