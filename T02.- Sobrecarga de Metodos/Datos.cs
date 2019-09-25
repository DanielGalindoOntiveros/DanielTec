using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.__Sobrecarga_de_Metodos
{
    class Datos
    {
        //metodo para recopilar datos y almacenar el resultado
        public void ObtenerDatos()
        {
            Operaciones op = new Operaciones();

            Console.WriteLine("\ningrese 2 datos:");


            Console.WriteLine("dato 1:");
            double D1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("dato 2:");
            double D2 = Convert.ToDouble(Console.ReadLine());

            double Res = op.Sumar(D1, D2);


            Console.WriteLine("Resultado =" + Res);


        }
    }
}
