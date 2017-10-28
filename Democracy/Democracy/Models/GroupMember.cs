using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Democracy.Models
{
    public class GroupMember
    {
        [Key]
        public int GroupMemberId { get; set; }

        public int GroupId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        public int UserId { get; set; }


        public virtual Group Group { get; set; }
        public virtual User User { get; set; }
    }
}