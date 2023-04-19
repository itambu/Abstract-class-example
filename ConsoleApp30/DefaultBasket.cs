using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    public class DefaultBasket : ICostable
    {
        public List<IElement> Items { get; protected set; }

        public DefaultBasket(List<IElement> items) 
        {
            Items = items;
        }

        public decimal Cost
        {
            get 
            {
                // mandatory action
                Console.WriteLine("Surprise!");

                return GetTotalCost();
               
            }
        }

        protected virtual decimal GetTotalCost()
        {
                if (Items is null)
                {
                    throw new NullReferenceException($"{nameof(Item)} is null");
                }

                decimal temp = 0;
                foreach (Item item in Items)
                {
                    temp += item.Cost;
                }

                return temp;
        }
    }
}
