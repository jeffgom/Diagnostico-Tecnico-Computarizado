using Inventario.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.BL
{
    public class TiposBL
    {

        public BindingList<Tipo> ListadeTipos { get; set; }

        public TiposBL()
        {
            ListadeTipos = new BindingList<Tipo>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var tipo1 = new Tipo(001, " Electrica ", " Americana ");
            var tipo2 = new Tipo(010, " Mecanica ", " Europea ");
            var tipo3 = new Tipo(100, " Electrica ", " China ");

            ListadeTipos.Add(tipo1);
            ListadeTipos.Add(tipo2);
            ListadeTipos.Add(tipo3);
        }

    }
}
