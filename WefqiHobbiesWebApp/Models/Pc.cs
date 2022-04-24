using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WefqiHobbiesWebApp.Models
{
    public class Pc
    {
        public int ID { get; set; }
        [Display(Name = "Graphics Card")]
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string GraphicsCard { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Cpu { get; set; }
        [Required]
        public string Ram { get; set; }
        [Display(Name = "Storage Space")]
        [Required]
        public string StorageSpace { get; set; }
    }
}
