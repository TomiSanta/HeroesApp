using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZHgyakorlas4.Models
{
    public class Item
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [ForeignKey("ReferencedHero")]
        public int HeroId { get; set; }
        public virtual Hero? ReferencedHero { get; set; }
    }
}
