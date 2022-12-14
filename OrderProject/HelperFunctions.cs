using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProject
{
   public static class HelperFunctions
    {
        public static List<Customer> FillCustomers()
        {
            Guid[] customersId= { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003") };
            string[] customersFirstName = { "Aliev", "Valiev", "Ganiev" };
            string[] customersLastName = { "Vali", "Gani", "Ali" };
            double[] customersBalance = { 50, 89, 142.5 };
            string[] customersPhoneNumber = { "+999292999999", "+999292998888", "+999292997777" };
            DateTime[] customersBirthDate = { new DateTime(1990, 01, 12), new DateTime(1995, 08, 14), new DateTime(1999, 06, 23) };
            var  Customers = new List<Customer>();
            for (int i = 0; i <= customersFirstName.Length - 1; i++)
            {
                Customers.Add(new Customer
                {
                    Id = customersId[i],
                    FirstName = customersFirstName[i],
                    LastName = customersLastName[i],
                    Balance = customersBalance[i],
                    Age = DifferenceTotalYears(customersBirthDate[i], DateTime.Now),
                    PhoneNumber = customersPhoneNumber[i],
                    BirthDate = customersBirthDate[i]
                });
            }
          
            return Customers;
        }


        public static List<Deliveryman> FillDeliveryman()
        {
            Guid[] deliverymanId = { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") };
            string[] deliverymanFirstName = { "Сourier", "Сourier"};
            string[] deliverymanLastName = { "One", "Two" };
            string[] deliverymanPhoneNumber = { "+9992929565659", "+9992929656565" };
            DateTime[] deliverymanBirthDate = { new DateTime(1999, 03, 13), new DateTime(1997, 09, 21) };
            var Deliverymans = new List<Deliveryman>();
            for (int i = 0; i <= deliverymanFirstName.Length - 1; i++)
            {
              Deliverymans.Add( 
                new Deliveryman
                {
                    Id=deliverymanId[i],
                    FirstName = deliverymanFirstName[i],
                    LastName = deliverymanLastName[i],
                    Age = DifferenceTotalYears(deliverymanBirthDate[i],DateTime.Now),
                    PhoneNumber = deliverymanPhoneNumber[i],
                    BirthDate = deliverymanBirthDate[i]
                });
            }
            return Deliverymans;
        }

        public static List<Product> FillProduct()
        {
            Guid[] productId = { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004") };
            string[] productName = { "Apple", "Banana","Rice","Milk"};
            DateTime[] productManufatureDate = { new DateTime(2022, 03, 13), new DateTime(2022, 09, 21) , new DateTime(2021, 08, 17) , new DateTime(2020, 09, 21) };
            DateTime[] productExpirationDate = { new DateTime(2022, 03, 13), new DateTime(2025, 09, 21), new DateTime(2022, 08, 16) , new DateTime(2022, 12, 21) };
            double[] productPrice = { 8, 4, 10.5, 12.5 };
            string[] productUnits = { ConfigurationConstant.Units.Kg, ConfigurationConstant.Units.Piece, ConfigurationConstant.Units.Kg, ConfigurationConstant.Units.Liter };
            var  Products = new List<Product>();
            for (int i = 0; i <= productName.Length -1; i++)
            {
                Products.Add(
                new Product
                {
                    Id = productId[i],
                    Name = productName[i],
                    ManufactureDate=productManufatureDate[i],
                    ExpirationDate = productExpirationDate[i],
                    Price = productPrice[i],
                    Unit=productUnits[i]
                });
            }
            return Products;
        }

        public static int DifferenceTotalYears(this DateTime start, DateTime end)
        {
            // Get difference in total months.
            int months = ((end.Year - start.Year) * 12) + (end.Month - start.Month);
            // substract 1 month if end month is not completed
            if (end.Day < start.Day)
            {
                months--;
            }
            int totalyears = months / 12;
            return totalyears;
        }
  

    }
    }

