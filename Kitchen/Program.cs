using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu p = new Menu();
            p.ListaMenu();
            p.CrearMenu();
          
            Console.ReadKey();
        }
    }
}
