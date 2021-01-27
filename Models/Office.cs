using System;
using System.ComponentModel.DataAnnotations;

namespace DdPortal.Models
{
    public class Office 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MarketUnit { get; set; }
        public string City { get; set; }
        public string Address { get; set; }


    }
}