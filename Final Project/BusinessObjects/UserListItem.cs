using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class UserListItem
    {
        [Required]
        public string Item { get; set; }
        public bool IsChecked { get; set; }
    }
}
