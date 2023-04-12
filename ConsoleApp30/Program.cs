// See https://aka.ms/new-console-template for more information
using ConsoleApp30;

Console.WriteLine("Hello, World!");

////////////////////////////////////

List<Item> items = new List<Item>() { new Item() { Name = "Грабли", Cost = 100 } };
DefaultBasket db = new DefaultBasket(items);
DefaultBasket pcb = new PromoCodeBasket(items);

//--------------------------------------------------------------------------------

Order or1 = new Order() { Basket = db };
Order or2 = new Order() { Basket = pcb };

or1.Submit();
or2.Submit();

DeliverHelper dh = new MailDeliveryHelper();

dh.Delivery(or1);
dh.Delivery(or2);



//DefaultBasket db1 = pcb;

//PromoCodeBasket pcb1 = (PromoCodeBasket)db1;

//if (db1 is  PromoCodeBasket)
//{
//    var t = ((PromoCodeBasket)db1).TotalCost;
//}

//var pcb2 = db1 as PromoCodeBasket;
//if (pcb2 is not null)
//{
//    var t = pcb2.TotalCost;
//}





