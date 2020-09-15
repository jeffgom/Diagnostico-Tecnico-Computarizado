using Inventario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.BL
{
    public class ClientesBL
    {

        public List<Cliente> ListadeClientes { get; set; }

        public ClientesBL()
        {
            ListadeClientes = new List<Cliente>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {

            var ciudad1 = new Direccion(01, "Colonia los alamos");
            var ciudad2 = new Direccion(02, "Residencial los castaños");
            var ciudad3 = new Direccion(03, "Baracoa");

            var cliente1 = new Cliente(0506199700229, "Jeffry", "Gomez", "98244617", ciudad1 ,DateTime.Now);
            var cliente2 = new Cliente(0611198001984, "Ana", "Alvarenga", "97245838", ciudad3, DateTime.Now);
            var cliente3 = new Cliente(0506199500789, "Dalia", "Ramos", "95712916", ciudad2, DateTime.Now);
            var cliente4 = new Cliente(0506199700136, "Cris", "Gomez", "98244617", ciudad3, DateTime.Now);

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);
            ListadeClientes.Add(cliente4);
        }

    }
}
