using System;

namespace DelegateFunc
{
    class Program
    {
        //Func è un delegate che a differenza di Action ritorna un risultato. Viene solitamente usato per eseguire una funzione/azione che deve ritornare un risultato

        //Definisco una mia funzione che ritorna una stringa come risultato
        public string myFunctionSum(int a, int b)
        {
            //Eseguo la somma di a + b
            string str = string.Format("Somma {0}", (a + b));
            return str;
        }


        static void Main(string[] args)
        {
            //Credo istanza di program
            Program p = new Program();

            //Assegno myFunctionSum al delegate Func
            Func<int, int, string> func = p.myFunctionSum;
            string result = func(2, 4);
            Console.WriteLine(result); //Stampa la somma
           
            Console.WriteLine();
            Console.WriteLine("Premi INVIO per terminare...");
            Console.ReadLine();
        }
    }
}
