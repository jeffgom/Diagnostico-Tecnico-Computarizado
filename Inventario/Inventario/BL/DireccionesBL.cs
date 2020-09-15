using Inventario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.BL
{
    public class DireccionesBL
    {

        public List<Direccion> ListadeDirecciones { get; set; }

        public DireccionesBL()
        {

            ListadeDirecciones = new List<Direccion>();
            CrearDatosdePrueba();

        }

        private void CrearDatosdePrueba()
        {

            var ciudad1 = new Direccion(01, "Colonia los alamos");
            var ciudad2 = new Direccion(02, "Residencial los castaños");
            var ciudad3 = new Direccion(03, "Baracoa");

            ListadeDirecciones.Add(ciudad1);
            ListadeDirecciones.Add(ciudad2);
            ListadeDirecciones.Add(ciudad3);

        }

    }
}
