using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Calculadora----------");
            Operaciones op = new Operaciones();
            double a, b;
            Console.Write("\n" + "Introduce el 1er número: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n" + "Introduce el 2do número: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n" + "Seleccione una opción: " + "\n" + "\n");
            Console.Write("\n" + "     1º) Suma" + "\n" + "     2º) Resta" + "\n" + "     3º) Multiplicación" + "\n" + "     4º) División" + "\n" + "     5º) Salir del Programa" + "\n" + "\n");

            switch (Console.Read())

            {
                case '1':
                    double Res1 = op.Suma(a, b);
                    Console.Write("resultado = " + Res1);
                    break;

                case '2':
                    double Res2 = op.Resta(a, b);
                    Console.Write("resultado = " + Res2);
                    break;

                case '3':
                    double Res3 = op.Multiplicacion(a, b);
                    Console.Write("resultado = " + Res3);
                    break;

                case '4':
                    double Res4 = op.Division(a, b);
                    Console.Write("resultado = " + Res4);
                    break;

                case '5':
                    Console.Write("-------------fin-------------");
                    break;
            }
            /*esto es para dejar el resultado hasta que pulses una tecla*/

            Console.ReadKey();

        }
    }
}
