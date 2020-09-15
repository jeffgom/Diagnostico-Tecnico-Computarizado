using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Modelos
{
    public class Direccion
    {

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Direccion()
        {

        }

        public Direccion(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

    }
}
