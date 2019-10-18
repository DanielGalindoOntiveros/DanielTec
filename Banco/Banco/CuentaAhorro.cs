using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    //herencia de cuenta
    class CuentaAhorro : Cuenta
    {
        //propiedades de la cuenta ahorro
        public DateTime Expiration { get; set; }

        //metodo para el ingreso
        public double IngresoPorMes()
        {
            return 0;
        }
    }
}