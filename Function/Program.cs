using System;

namespace Function
{
    class Program
    {
        //Semplice esempio di uso di una Function sfruttando Lambda Expression
        static void Main(string[] args)
        {
            //Creo una data di nascita
            DateTime dob = new DateTime(2001, 10, 20);
            Console.WriteLine($"Data di nascita: {dob.ToShortDateString()}");

            //T1 è il tipo in ingresso, T2 è il tipo restituito
            Func<DateTime, bool> canDrive = 
                dob => dob.AddYears(18) <= DateTime.Today; //Lambda Expression con un parametro in ingresso "dob"

            //Invoco l'esecuzione della function con "canDrive(dob)", il tipo ritornato sarà un bool
            Console.WriteLine($"Ad oggi {DateTime.Today.ToShortDateString()} può guidare? {canDrive(dob)}");
            Console.ReadLine();
        }
    }
}
