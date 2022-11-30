using System.ComponentModel.DataAnnotations;

namespace ZHgyakorlas4.Models
{
    public class Hero
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string HeroName { get; set; }
        [Required]
        public string Power { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
