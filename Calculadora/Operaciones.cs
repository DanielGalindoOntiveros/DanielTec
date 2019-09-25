using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operaciones
    {
        /*Declarar los numeros*/
        public double Suma(double a, double b)
        /*Las funciones o "programas" de la calculadora*/
        {
            double suma = a + b;
            return suma;
        }

        public double Resta(double a, double b)
        {
            double resta = a - b;
            return resta;
        }

        public double Multiplicacion(double a, double b)
        {
            double multi = a * b;
            return multi;
        }

        public double Division(double a, double b)
        {
            double divi = a / b;
            return divi;
        }


    }
}
