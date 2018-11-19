using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class UserListModel
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public List<UserListItem> ItemsList { get; set; }
        public bool Selected { get; set; }
    }
}
