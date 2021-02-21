using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreAssignment.Models
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public int Discount { get; set; }
        public float TotalPrice { get; set; }
        public string Rating { get; set; }
        public HrefViewModel Href { get; set; }
    }
}