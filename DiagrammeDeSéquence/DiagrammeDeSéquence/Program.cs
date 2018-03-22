using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagrammeDeSéquence
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client("Fred");
            Cook cuisto = new Cook("Hank");
            Cashier caisse = new Cashier("Renée");
            Waiter w = new Waiter("Bob", cuisto, caisse);

            c.SeMetATable(w);
            Console.ReadLine();
        }
    }
}
