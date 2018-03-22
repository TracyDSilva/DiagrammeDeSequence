using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagrammeDeSéquence
{
    class Cashier:Personne
    {
        public Cashier(string nom)
            : base(nom)
        {
        }

        public void Pay()
        {
            Console.WriteLine("Par ici la monnaie !");
        }
    }
}
