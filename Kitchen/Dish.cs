using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Dish
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }

        public void Show_Product(Dish[] P)
        {
            Console.WriteLine("Available Dishes");
            for (int i = 0; i < P.Length; i++)
            {
                if (P[i] != null)
                    Console.WriteLine(P[i].Nombre + "\t" + P[i].Categoria + "\t" + P[i].Descripcion);
                Console.ReadKey();
            }
        }
    }
}
