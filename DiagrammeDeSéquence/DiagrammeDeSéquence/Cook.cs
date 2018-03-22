using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagrammeDeSéquence
{
    class Cook:Personne
    {
        public Cook(string nom)
            : base(nom)
        {
        }

        public void OrderFood(Waiter unServeur)
        {
            Console.WriteLine("Plat du jour ? Ca marche !");
            unServeur.PickUp();
        }
    }
}
