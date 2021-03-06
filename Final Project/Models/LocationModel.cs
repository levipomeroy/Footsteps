﻿using Final_Project.BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class LocationModel
    {
        [RegularExpression("([0-9]+)", ErrorMessage = "ID must be a number")]
        public int ID { get; set; }

        public string Country { get; set; }

        [Required(ErrorMessage = "Latitude is a required field")]
        [RegularExpression("\\-?\\d+(\\.\\d+)?", ErrorMessage = "Latitude must be of the form +-xx.xxxxxx")]
        public double Latitude { get; set; }

        [Required(ErrorMessage = "Longitude is a required field")]
        [RegularExpression("\\-?\\d+(\\.\\d+)?", ErrorMessage = "Longitude must be of the form +-xx.xxxxxx")]
        public double Longitude { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Name cannot be more than 25 characters long")]
        public string Name { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "Name cannot be more than 1000 characters long")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Category is a required field")]
        public string Category { get; set; }

        public List<LocationObject> LocationList { get; set; }

        public string UserID { get; set; }

        [Required(ErrorMessage = "Date Visited is a required field")]
        public string DateVisited { get; set; }

        public List<string> CategoryOptions = new List<string> { "Visited", "Want to go", "Plan to go", "Lived" };

        public List<string> Images { get; set; }

        public string Theme { get; set; }
    }
}
