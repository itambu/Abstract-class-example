using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    public class PromoCodeBasket : DefaultBasket
    {
        private const decimal minBasketCost = 30;
        private const decimal discountRate = 0.30m;

        public PromoCodeBasket(List<IElement> items) : base(items)
        {
        }

        protected override decimal GetTotalCost()
        {

            var temp = base.GetTotalCost();


            if (temp > minBasketCost)
                {
                    temp *= discountRate;
                }
                return temp;
            }
        }
}
