using System;

namespace Delegate
{
    class Program
    {

        //Un delegate è un tipo riferimento usato per incapsulare un metodo. Sostanzialmente il metodo si "comporta" come un oggetto: le istanze di un delegate, permettono di eseguire dei metodi. 
        //In questo esempio il delegate ritornerà un bool, ma solitamente è preferibile che non ritorni un risultato, soprattutto quando li si usa in multicast, come nel progetto "Delegate.Multicast" presente in questa soluzione 
        public delegate bool ConfrontoDelegate(int x, int y);

        static void Main(string[] args)
        {
           //instanzio la classe contenente i metodi con la concretizzazione del delegate 
            ConcreteDelegate cd = new ConcreteDelegate();

            //assegno al delegate uno dei metodi della classe concreta 
            ConfrontoDelegate confrDeleg = cd.MaggioreDi;
            Console.WriteLine("10 è maggiore di 3: " + confrDeleg(10, 3));
        
            //sostituisco l'assegnazione con un'altro dei metodi della classe concreta
            confrDeleg = cd.MinoreDi;
            Console.WriteLine("10 è minore di 3: " + confrDeleg(10, 3));

            confrDeleg = cd.UgualeA;
            Console.WriteLine("10 è uguale a 3: " + confrDeleg(10, 3));

            Console.WriteLine();
            Console.WriteLine("Premi invio per terminare...");
            Console.ReadLine();
        }
    }
}
