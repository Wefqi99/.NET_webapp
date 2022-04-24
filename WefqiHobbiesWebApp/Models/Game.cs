using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WefqiHobbiesWebApp.Models
{
    public class Game
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Company { get; set; }
        [Display(Name = "Hours Played")]
        [Required]
        public string HoursPlayed { get; set; }
        [Required]
        [Display(Name = "Date Finished")]
        [StringLength(20, MinimumLength = 3)]
        public string DateFinished { get; set; }
    }
}
