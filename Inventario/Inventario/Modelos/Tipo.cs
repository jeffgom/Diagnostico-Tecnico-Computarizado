using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Modelos
{
    public class Tipo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Procedencia { get; set; }

        public Tipo(int id, string descripcion, string procedencia)
        {
            Id = id;
            Descripcion = descripcion;
            Procedencia = procedencia;
        }

    }
}
