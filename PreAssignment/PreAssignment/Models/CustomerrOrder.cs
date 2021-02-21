using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreAssignment.Models
{
    public class CustomerrOrder
    {
        public int CustomerrOrderId { get; set; }
        public DateTime Date { get; set; }
        public int Qty { get; set; }
        public Customerr Customerr { get; set; }

    }
}