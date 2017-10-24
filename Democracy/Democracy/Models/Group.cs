using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Democracy.Models
{
    public class Group
    {
        /// <summary>
        /// Gets or sets the grpup id
        /// </summary>
        [Key]
        public int GroupId { get; set; }
        /// <summary>
        /// Gets or sets the group description
        /// </summary>
        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(50, ErrorMessage =
                    "The field {0} can contain maximum {1} and minimum {2} character",
                    MinimumLength = 3)]
        public string Description { get; set; }
    }
}