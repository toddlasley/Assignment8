using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStoreMVC.Models
{
    public class Pet
    {
        public Int32 ID { get; set; }
        public string Description { get; set; }
        public DateTime DateReceived { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}