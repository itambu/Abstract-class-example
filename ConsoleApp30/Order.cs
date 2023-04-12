using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp30
{
    public class Order
    {
        public DefaultBasket? Basket { get; set; }
        
        public void Submit()
        {
            //PromoCodeBasket p = Basket as PromoCodeBasket;
            //if (p != null)
            //{
            //    Console.WriteLine($"Basket cost is {p.TotalCost}");
            //}
            //else
            //{
            //    Console.WriteLine($"Basket cost is {Basket.TotalCost}");
            //}

            Console.WriteLine($"Basket cost is {Basket.TotalCost}");
        }


    }
}