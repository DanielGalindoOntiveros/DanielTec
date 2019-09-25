using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.__Sobrecarga_de_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {

            //llamamos la clase operacion 
            Operaciones op = new Operaciones();

            var Res1 = op.Sumar(2, 3, 4);
            Console.WriteLine("Tu resultado es: ");
            Console.WriteLine(Res1);

            var Res2 = op.Sumar(2, 3);
            Console.WriteLine("Tu resultado es: ");
            Console.WriteLine(Res2);

            var Res3 = op.Sumar(2);
            Console.WriteLine("Tu resultado es: ");
            Console.WriteLine(Res3);

            var Res4 = op.Sumar();
            Console.WriteLine("Tu resultado es: ");
            Console.WriteLine(Res4);



            //llamamos la clase datos para pder utilizar el metodo dentro de ella
            Datos d = new Datos();
            d.ObtenerDatos();


            Console.ReadKey();
        }
    }
}
