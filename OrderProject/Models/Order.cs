using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProject
{
    public class Order : Basket

    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ClosedOn { get; set; }
        public Guid DeliverimanId { get; set; }
        public Deliveryman Deliveryman { get; set; }
        public string Status { get; set; }
        public List<Basket> ProductsList = new List<Basket>();

    }
}
