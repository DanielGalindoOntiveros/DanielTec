using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga1
{
    class Program
    {
        static void Main(string[] args)
        {

            //llamamos la clase metodos
            COperaciones op = new COperaciones();
            //creamos una variable para almacenar la respuesta
            var Res1 = op.Multiplicar(2,3,4);
            Console.WriteLine("Tu resultado es:");
            Console.WriteLine(Res1);
            //creamos una variable para almacenar la respuesta
            var Res2 = op.Multiplicar(2, 3);
            Console.WriteLine("Tu resultado es:");
            Console.WriteLine(Res2);
            //creamos una variable para almacenar la respuesta
            var Res3 = op.Multiplicar(2);
            Console.WriteLine("Tu resultado es:");
            Console.WriteLine(Res3);
            //creamos una variable para almacenar la respuesta
            var Res4 = op.Multiplicar();
            Console.WriteLine("Tu resultado es:");
            Console.WriteLine(Res4);



            //llamamos la clase datos
            //instanciamos el metodo obtener datos para utlizar la funcion de qu eel usuario haga input los datos
            Datos d = new Datos();
            d.ObtenerDatos();
        
          
            Console.ReadKey();

        }

    }
}
