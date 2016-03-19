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

        public string Name { get; set; }

        public string Description { get; set; }

        [Display(Name = "Date Received")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public string DateReceived { get; set; }

        public int Quantity { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }
    }
}