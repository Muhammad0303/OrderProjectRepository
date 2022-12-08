using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProject
{
    public class Deliveryman : Person
    {
        public string GetOrder( List<Order> order,int orderId) {
            string result;
            if (order.Count > 0)
            {
               var findedOrder = order.Find(x => x.Id == orderId);
                if (findedOrder != null && findedOrder.Status==ConfigurationConstant.OrderStatus.New)
                {
                    findedOrder.DeliverimanId = Id;
                    findedOrder.Status = ConfigurationConstant.OrderStatus.WaitDelivery;
                    return "Успешно оформлен!";
                }
               
            }
            return "Ошибка: Заказ не найден или статус  заказа не соответсвует!";
        }
        public string CloseOrder(List<Order> order, int orderId)
        {
            if (order.Count > 0)
            {
                var findedOrder = order.Find(x => x.Id == orderId);
                if (findedOrder != null && findedOrder.Status == ConfigurationConstant.OrderStatus.WaitDelivery)
                {
                    findedOrder.ClosedOn = DateTime.Now;
                    findedOrder.Status = ConfigurationConstant.OrderStatus.Delivered;
                    return "Доставка завершена. Заказ успешно закрыть!";
                }

            }
            return "Ошибка: Заказ не найден или статус  заказа не соответсвует!";
        }
    }
}
