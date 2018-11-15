using System;

namespace ExShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: 
            // petle
            // tworzenie instancji
            // tworzenie i wywolywanie metod
            // logika calego programu
            // troche cleancode'u i porzadkow
            // troche resharpera?

            //TODO:
            // scenariusz dla klienta
            // weryfikacja klienta
            // wchodzi do wybranego sklepu, albo wychodzi z menu
            // wybiera przedmioty
            // wybiera czy chce kupic czy anulowac
            // placi

            var arek = new Customer(2, "Arek", "Klis", "arek9513@gmail.com");
            var biedak = new Customer(3, "Pan", "Zul", "brak", 5.5);
            var mracin = new Customer();

            var maczuga = new Item();
            maczuga.id = 1;
            maczuga.name = "Kolecx20";

            var dildo = new Item
            {
                id = 2,
                name = "Smooth"
            };


            var itemsList = new Item[]
            {
                maczuga,
                dildo
            };

            var biedronka = new Shop(1, "Biedronka", itemsList);

            foreach (var item in itemsList)
            {
                Console.WriteLine(item.name);
            }
            
            Console.WriteLine(biedronka.Items[1].name);

        }
    }
}
