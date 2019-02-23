using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class ConcreteDelegate
    {
        //Tutti questi metodi sono compatibili con il delegate definito nella classe progam, infatti hanno stessa firma e stesso tipo ritornato
        public bool MaggioreDi(int x, int y)
        {
            return (x > y) ? true : false;
        }

        public bool MinoreDi(int x, int y)
        {
            return (x < y) ? true : false;
        }

        public bool UgualeA(int x, int y)
        {
            return (x == y) ? true : false;
        }


    }
}
