using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateGenerici
{
    class ConcreteDelegate
    {
        //Tutti questi metodi sono compatibili con il delegate definito nella classe progam, infatti hanno stessa firma e stesso tipo ritornato
        public void MaggioreDi(double x, double y)
        {
            bool magDi = (x > y) ? true : false;
            Console.WriteLine($"{x} è maggiore di {y}: {magDi}");
        }

        public void MinoreDi(int x, int y)
        {
            bool minDi = (x < y) ? true : false;
            Console.WriteLine($"{x} è minore di {y}: {minDi}");
        }

        public void UgualeA(int x, int y)
        {
            bool ugualeA = (x == y) ? true : false;
            Console.WriteLine($"{x} è uguale a {y}: {ugualeA}");
        }

    } 
}
