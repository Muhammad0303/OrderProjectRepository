using OrderProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProject
{
    public class Product:EntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
    }
}
