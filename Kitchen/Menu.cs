using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Menu : Dish, IMenu
    {
        int n = 0;
        int count = 0;
        Dish[] List;

        public void CrearMenu()
        {

            List = new Dish[1000];
            Dish D = new Dish();
            Console.WriteLine("Would you like to add a dish");
            Console.WriteLine("y/n");
            if (Console.ReadLine() == "y")

            Console.WriteLine("Name:");
            D.Nombre = Console.ReadLine();

            Console.WriteLine("Category:");
            D.Categoria = Console.ReadLine();

            Console.WriteLine("Description:");
            D.Descripcion = Console.ReadLine();


            //crear un contador//
            //Dtermina cuantos elementos hay en el arreglo//

            D.ID = count;

            List[count] = D;
            count++;
            ListaMenu();
          
        }

       
        public void ListaMenu()
        {
            int n;
            Console.WriteLine("Welcome");
            Console.WriteLine("1.- Add a dish");
            Console.WriteLine("2.- show dishes");
            Console.WriteLine("5.- Close Program");

            Console.WriteLine("Seleccione una opcion");
            n = int.Parse(Console.ReadLine());
            switch (n)

            {
                case 1:
                    CrearMenu();
                    break;

                case 2:
                    Dish R = new Dish();
                    R.Show_Product(List);
                    break;


            }
        }
    }
}
