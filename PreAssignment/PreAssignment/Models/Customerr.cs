using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreAssignment.Models
{
    public class Customerr
    {
        public int CustomerrId { get; set; }
        public string Name { get; set; }
        public ICollection<CustomerrOrder> CustomerrOrder { get; set; }
    }
}