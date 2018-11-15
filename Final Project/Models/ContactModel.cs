using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Name cannot be empty")]
        [StringLength(25, ErrorMessage = "Name cannot be more than 25 characters long")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Type is requred")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Message cannot be empty")]
        [StringLength(1000, ErrorMessage = "Message cannot be more than 1000 characters long")]
        public string Message { get; set; }
    }
}
