using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProject
{
    public static class ConfigurationConstant
    {
        public static  class Units {
            public static readonly string Kg = "килограмм";
            public static readonly string Piece = "штук";
            public static readonly string Liter = "литр";
        }

        public static class OrderStatus
        {
            public static readonly string New = "Новый";
            public static readonly string WaitDelivery = "Ожидание доставки";
            public static readonly string Delivered = "Доставлен";
            public static readonly string Canceled = "Отменён";
        }
    }
}
