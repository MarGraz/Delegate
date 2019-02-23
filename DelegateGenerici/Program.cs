using System;

namespace DelegateGenerici
{
    class Program
    {
        //uso dei tipi generici per passare gli argomenti al delegate.
        //il where T serve a vincolare gli argomenti solo a tipi specifici, ossia struct, quali: int, double, float, ecc. Non sarà ad esempio possibile usare delle stringhe
        public delegate void ConfrontoDelegate<T>(T x, T y) where T : struct;

        static void Main(string[] args)
        {
            //instanzio la classe contenente i metodi con la concretizzazione del delegate 
            ConcreteDelegate cd = new ConcreteDelegate();

            //visto l'uso dei generici, è ora necessario specificare il tipo di riferimento 
            ConfrontoDelegate<double> confrDelegDouble = cd.MaggioreDi;
            ConfrontoDelegate<int> confrDelegInt = cd.MinoreDi;

            confrDelegDouble(10.2, 4.2);
            confrDelegInt(10, 4);

            //in questo caso è bene che i metodi concretizzati del delegate ritornino sempre void, onde evitare che si peschi solo l'utlimo di tutti i controlli eseguiti in sequenza
            //va ricordato che una qualunque eccezione, interromperà il multicast

            Console.WriteLine();
            Console.WriteLine("Premi invio per terminare...");
            Console.ReadLine();
        }
    }
}
