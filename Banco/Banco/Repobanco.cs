using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Repobanco
    {
        // 
        CuentaData ad;
        public Repobanco()
        {
            //instancia de los datos de las cuentas
            ad = new CuentaData();
        }
        internal void Principal()
        {
            Console.WriteLine("Bienvenidos A el Banco mi Casita");
            Menu();
            Console.ReadLine();
        }
        //creacion del menu
        private void Menu()
        {
            Console.WriteLine("Ingrese a la Opcion Correcta");
            Console.WriteLine("1.- Cuenta Ahorro \n2.- Pensiones \n3.- Cuenta Corriente");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Bienvenido a Cuenta Ahorro");
                    GetDataSave();
                    break;
                case "2":
                    Console.WriteLine("Bienvenido a Pensiones");
                    GetDataPension();

                    break;

                case "3":
                    Console.WriteLine("Bienvenido a Cuenta Corriente");
                    GetDataCurrent();
                    break;

                default:
                    break;
            }
        }

        private void GetDataCurrent()
        {
            int number = GetData();

        }


        // jala la informacion almacenada en la cuentadata
        private void GetDataPension()
        {
            int number = GetData();
            var lista = ad.Pensiones();
            Pensiones p = new Pensiones();

            foreach (var cuenta in lista)
            {
               //comprueba la existencia de la cuenta
                if (number == cuenta.AccountNumber)
                {
                    p = cuenta;
                }
                
            }

            Console.WriteLine("Bienvenido " + p.Headline);

            MenuUsuario(p);
        }
        //creacion del menu que se mostrara cuando el usuario ingrese a su cuenta
        private void MenuUsuario(Cuenta p)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a tu Cuenta :" + p.Headline);
            Console.WriteLine("1.- Consultar Saldo \n2.- Transferir \n3.- Interes x Mes 4.- Ingreso");
            Console.WriteLine("Elije una Opcion");

            switch (Console.ReadLine())
            {
                case "1":
                    p.ConsultarSaldo(p);
                    break;
                case "2":

                    break;
                case "3":
                    //muestra el interes generado
                    Console.WriteLine("EL interes Generado es de : " + p.InteresPorMes(p));
                    break;
                case "4":

                    break;

                default:
                    break;
            }

        }

        private void GetDataSave()
        {
            int number = GetData();
        }

        private int GetData()
        {
            //pide la informacion para acceder a la cuenta
            Console.WriteLine("Ingrese Su Numero de Cuenta");
            string res = Console.ReadLine();
            return Convert.ToInt32(res);
        }


    }
}