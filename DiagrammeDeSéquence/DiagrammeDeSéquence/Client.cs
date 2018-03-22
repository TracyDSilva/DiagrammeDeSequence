using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagrammeDeSéquence
{
    class Client:Personne
    {
        public Client(string nom)
            : base(nom)
        {
        }
        public void SeMetATable(Waiter unServeur)
        {
            Console.WriteLine("Serveur !");
            unServeur.Orderfood(this);

        }

        public void ServeWine()
        {
            Console.WriteLine("Enfin, j'ai soif !");
        }

        public void ServeFood(Cashier leCaissier)
        {
            Console.WriteLine("Merci.");
            leCaissier.Pay();
        }
    }
}
