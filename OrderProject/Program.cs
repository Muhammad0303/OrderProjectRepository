using OrderProject.DataProvider;
using System;
using System.Collections.Generic;

namespace OrderProject
{
    class Program
    {
        static void Main(string[] args)

        {
           // var dataProvider = new JsonDataProvider();
            //dataProvider.Add()  

            List<Order> Orders = new List<Order>();
      

            List<Customer> Customers = HelperFunctions.FillCustomers();
            List<Deliveryman>  Delivelirymans = HelperFunctions.FillDeliveryman();
            List<Product> Products = HelperFunctions.FillProduct();
  
            Customers[0].AddProductToBasket(Products[0],10);
            Customers[0].AddProductToBasket(Products[3],2);
            foreach(var item in Customers[0].basket)
            {
                Console.WriteLine($" Название: {item.Product.Name} \t Цена: {item.Product.Price} \t Количество: {item.Count }" );
            }
         
            //Customers[0].DeleteElementFromBasketById(2);

            Customers[0].CreateOrder(ref Orders,out string message);
            Console.WriteLine(message);
            Console.WriteLine(Delivelirymans[0].GetOrder(Orders, 0));
            Console.WriteLine(Delivelirymans[0].CloseOrder(Orders, 0));         
    
            Console.ReadKey();

        }
    }
}
