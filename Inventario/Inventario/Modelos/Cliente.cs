using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Modelos
{
    public class Cliente
    {

        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public DateTime FechaV { get; set; }
        public Direccion Direccion { get; set; }
        public int DireccionId { get; set; }

        public Cliente(long id, string nombre, string apellido, string celular, Direccion direccion ,DateTime fecha)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Celular = celular;
            Direccion = direccion;
            DireccionId = direccion.Id;
            fecha = DateTime.Now;
        }
    }
}
