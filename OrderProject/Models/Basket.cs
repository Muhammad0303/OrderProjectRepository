using OrderProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProject
{
    public class Basket : EntityBase
    {
        public static int counter = 0;
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
   
        public int Count { get; set; }
        public Basket()
        {
            counter++;
        }
    }
}
