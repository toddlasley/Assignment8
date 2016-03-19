using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetStoreMVC.Models
{
    public class Pet
    {
        public Int32 ID { get; set; }

        public string Description { get; set; }

        [Display(Name = "Date Received")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public DateTime DateReceived { get; set; }

        public int Quantity { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }
    }
}