using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Name cannot be empty")]
        [StringLength(25, ErrorMessage = "Name cannot be more than 25 characters long")]
        public string UserName { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
