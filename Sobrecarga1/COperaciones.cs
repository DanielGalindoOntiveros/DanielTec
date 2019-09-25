using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga1
{
    class COperaciones
    {
        //metodos para las diferentes sobrecargas//

        public double Multiplicar (double a, double b, double c)
        {


            return a * b * c;
        }

        public double Multiplicar(double a, double b)
        {


            return a * b ;
        }

        public double Multiplicar(double a)
        {


            return a * 5;
        }

        public double Multiplicar()
        {


            return 5*5;
        }
    }
}
