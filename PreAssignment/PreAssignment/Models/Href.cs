using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PreAssignment.Models
{
    public class Href
    {
        [ForeignKey("Product")]
        public int HrefId { get; set; }
        public string Link { get; set; }
       
        public virtual Product Product { get; set; }
    }
}