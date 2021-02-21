using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreAssignment.Models
{
    public class DynamicFormModel
    {
        public string Field { get; set; }
        public string Type { get; set; }
        public int Min_Value { get; set; }
        public int Max_Length { get; set; }
        public List<string> Allowed_Values { get; set; }
       

    }
}