using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("tag")]
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("name")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("slug")]
        public string Slug { get; set; } = string.Empty;
    }
}