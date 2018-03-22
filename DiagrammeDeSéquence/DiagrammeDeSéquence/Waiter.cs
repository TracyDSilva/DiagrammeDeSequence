using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagrammeDeSéquence
{
    class Waiter:Personne
    {
        Cashier leCaissier;
        Cook monCuisinier;
        Client monClient;

        public void Orderfood(Client monClient)
        {
            Console.WriteLine("Je suis à votre disposition, que voulez-vous ?");
            this.monClient = monClient;
            monCuisinier.OrderFood(this);

        }

        public Waiter(string nom, Cook unCuisinier, Cashier leCaissier)
            :base(nom)
        {
            this.leCaissier = leCaissier;
            this.monCuisinier = unCuisinier;
        }

        public void PickUp()
        {
            this.monClient.ServeWine();
            this.monClient.ServeFood(leCaissier);
        }

    }
}
