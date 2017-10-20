using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Democracy.Models
{
    public class State
    {
        [Key]
        public int StateI { get; set; }

        public string Description { get; set; }
    }
}