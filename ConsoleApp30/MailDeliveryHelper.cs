using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp30
{
    public class MailDeliveryHelper : DeliverHelper
    {
        public override void Delivery(Order order)
        {
            Console.WriteLine("Order has been sent by usual mail");
        }
    }
}