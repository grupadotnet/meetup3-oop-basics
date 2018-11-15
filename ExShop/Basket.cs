using System;

namespace ExShop
{
    public class Basket
    {
        public Basket()
        {
            ItemsInBasket = 0;
            TotalPrice = 0;
        }

        public int ItemsInBasket { get; set; }
        public Item[] SelectedItems { get; set; }
        public double TotalPrice { get; set; }

        public void Buy(double availableCash)
        {
            foreach (var item in SelectedItems)
            {
                TotalPrice += item.price;
            }

            // tu wiecej scenariuszy, zadania dla grup
            if (availableCash >= TotalPrice)
            {
                Console.WriteLine("Wysylka w dordze");
            }
            else
            {
                Console.WriteLine("Nie stac cie biedaku");
            }
        }
    }
}