using System;
using System.ComponentModel.DataAnnotations;
namespace crudelicious.Models
{
    public class Dish
    {
        [Key]
        public int dishid { get; set; }
        [Required(ErrorMessage ="Dish name Required.")]
        public string name { get; set; }
        [Required(ErrorMessage ="Chef name Required.")]
        public string chef { get; set; }
        [Required]
         [Range(1,5, ErrorMessage ="Rating Must be 1-5")]
        public int tastiness { get; set; }
        [Required]
        [Range(1,int.MaxValue, ErrorMessage ="Calories must be more than 0.")]
        public string calories { get; set; }
        [Required (ErrorMessage ="Dish must have a description.")]
        public string description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}