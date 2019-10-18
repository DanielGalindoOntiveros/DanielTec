using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class CuentaData
    {
        //creacion de lista con los datos para los usuarios
        public List<Pensiones> Pensiones()
        {
            List<Pensiones> pensions = new List<Pensiones>();
            pensions.Add(new Pensiones { AccountNumber = 12345, Balance = 12.35M, Vencimiento = Convert.ToDateTime("11/05/2021"), Headline = "Juan Carlos Perez", Interest = 2.21, Numerocuentaorigen = 12322, Cotizacion = 25 });
            pensions.Add(new Pensiones { AccountNumber = 12765, Balance = 12.35M, Vencimiento = Convert.ToDateTime("14/03/2020"), Headline = "Juan  Perez", Interest = 2.21, Numerocuentaorigen = 12323, Cotizacion = 25 });
            pensions.Add(new Pensiones { AccountNumber = 12876, Balance = 12.35M, Vencimiento = Convert.ToDateTime("13/06/2023"), Headline = "Pedro Perez", Interest = 2.21, Numerocuentaorigen = 12321, Cotizacion = 25 });
            pensions.Add(new Pensiones { AccountNumber = 12865, Balance = 12.35M, Vencimiento = Convert.ToDateTime("13/02/2020"), Headline = "Pepe Perez", Interest = 2.21, Numerocuentaorigen = 12365, Cotizacion = 25 });
            pensions.Add(new Pensiones { AccountNumber = 12475, Balance = 12.35M, Vencimiento = Convert.ToDateTime("15/08/2022"), Headline = "Anotnio Torres", Interest = 2.21, Numerocuentaorigen = 14322, Cotizacion = 25 });
            return pensions;

        }
        //creacion de lista de cuenta ahorro para acumular los ahorros y poder mostrarlos
        public List<CuentaAhorro> Saves()
        {
            List< CuentaAhorro > saves = new List<CuentaAhorro> ();

            return saves;

        }
        //creacion de lista de cuenta corriente 
        public List<CuentaCorriente> Currents()
        {

            List<CuentaCorriente> currents = new List<CuentaCorriente>();

            return currents;

        }
    }
}