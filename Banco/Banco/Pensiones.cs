using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    //herencia de cuenta
    class Pensiones : Cuenta
    {
        // propiedades de la clase pensiones
        public DateTime Vencimiento { get; set; }
        public int Cotizacion { get; set; }
        public int Numerocuentaorigen { get; set; }
    }
}
