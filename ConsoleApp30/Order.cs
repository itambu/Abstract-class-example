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
            Console.WriteLine($"Basket cost is {Basket.Cost}");
        }


    }
}