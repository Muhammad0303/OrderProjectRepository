using OrderProject.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace OrderProject
{
    public class Customer : Person 
    {
        public double Balance { get; set; }
        public List<Basket> basket = new List<Basket>();
        public void AddProductToBasket(Product product,int count) {
            
            basket.Add(
            new Basket
            {
                Id=new Guid(),
                Product=product,
                ProductId=product.Id,
                Count=count
            });
        }
        public void  DeleteElementFromBasketById(Guid idElement)
        {
            var itemToRemove = basket.Find(x => x.Id == idElement);
            if (itemToRemove!=null) basket.Remove(itemToRemove);
        }
        public bool CreateOrder(ref List<Order> order,out string  resultMsg) {

            if (!CheckBalance())
            {
                resultMsg = "Недостаточно средств на балансе!";
                return false;
            }
            order.Add(
            new Order
            {
                Id=new Guid(),
                Customer=this,
                CustomerId=Id,
                CreatedOn=DateTime.Now,
                Status=ConfigurationConstant.OrderStatus.New,
                ProductsList = new List<Basket>(basket)            
            }    
            );
            
            basket.Clear();
            resultMsg = "Заказ успешно оформлен!";
            return true;

        }
        private bool CheckBalance()
        {
            double sumPrice = 0;
            foreach (Basket item in basket)
            {
                sumPrice +=item.Product.Price*item.Count;
            }
            if (Balance < sumPrice)
            {
                return false;
            }
            Balance -=sumPrice;
            return true;
        }
    }
}
