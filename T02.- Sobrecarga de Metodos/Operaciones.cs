using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.__Sobrecarga_de_Metodos
{
    class Operaciones
    {
        //declaramos los metodos para almacenar los datos

        public double Sumar(double a, double b, double c)
        {


            return a + b + c;
        }

        public double Sumar(double a, double b)
        {


            return a + b;
        }

        public double Sumar(double a)
        {


            return a + 5;
        }

        public double Sumar()
        {


            return 5 + 5;
        }
    }
}
