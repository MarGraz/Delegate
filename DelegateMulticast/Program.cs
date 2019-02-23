using System;

namespace DelegateMulticast
{
    class Program
    {
        //l'uso del multicast permette di assegnare ad una sola istanza del delegate l'esecuzione di più metodi
        //il delegate non ritorna nulla
        public delegate void ConfrontoDelegate(int x, int y);

        static void Main(string[] args)
        {
            //instanzio la classe contenente i metodi con la concretizzazione del delegate 
            ConcreteDelegate cd = new ConcreteDelegate();

            //assegno al delegate uno dei metodi della classe concreta 
            ConfrontoDelegate confrDeleg = cd.MaggioreDi;

            //aggiungo il secondo ed il tezo metodo, in questo modo il delegate ha più metodi ai quali puntare
            //l'uso del multicast permette di assegnare ad una sola istanza del delegate l'esecuzione di più metodi
            confrDeleg += cd.MinoreDi;
            confrDeleg += cd.UgualeA;

            //ora il delegate seguirà tutti e tre i controlli in sequenza
            confrDeleg(10, 4);

            //in questo caso è bene che i metodi concretizzati del delegate ritornino sempre void, onde evitare che si peschi solo l'utlimo di tutti i controlli eseguiti in sequenza
            //va ricordato che una qualunque eccezione, interromperà il multicast

            Console.WriteLine();
            Console.WriteLine("Premi invio per terminare...");
            Console.ReadLine();
        }
    }
}
