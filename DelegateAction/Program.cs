using System;

namespace DelegateAction
{
    class Program
    {
        //Action è un delegate che non ritorna nulla, è un tipo predefinito e come dice la parola stessa si tratta di un'azione, quindi la funzione non ritorna un risultato, ma void.
        void myFunction(int x, string s)
        {
            Console.WriteLine($"Intero: {x} e stringa: {s}");
            Console.WriteLine();
            Console.WriteLine("Premi INVIO per terminare...");
            Console.ReadLine();
        }



        static void Main(string[] args)
        {
            //Credo istanza di program
            Program p = new Program();

            //Instanzio il delegate Action. Esso può accettare fino a 16 tipi generici da passare
            Action<int, string> MyAction = p.myFunction;

            MyAction(7, "stringa");
        }
    }
}