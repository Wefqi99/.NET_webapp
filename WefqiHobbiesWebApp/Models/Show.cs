using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WefqiHobbiesWebApp.Models
{
    public class Show
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        [Display(Name = "Current Epsiode")]
        public string CurrentEpsiode { get; set; }
    }
}
