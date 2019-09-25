using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga1
{
    class Datos
    {
        //creacion del metodo el cual se encargara de recopilar 2 datos y almacenarlos
        public void ObtenerDatos()
        {
            COperaciones op = new COperaciones();
           
            Console.WriteLine("\ningrese 2 datos:");


            Console.WriteLine("dato 1:");
            double D1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("dato 2:");
            double D2 = Convert.ToDouble(Console.ReadLine());

            //llamos el metodo multiplicar para que jale las 2 variables y las multiplique

            double Res = op.Multiplicar(D1, D2);


                Console.WriteLine("Resultado =" + Res);

                
        }
    }
}
