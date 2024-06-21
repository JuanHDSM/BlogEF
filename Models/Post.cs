using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    [Table("post")]
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(160)]
        [Column("title")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(6)]
        [MaxLength(255)]
        [Column("summary")]
        public string Summary { get; set; } = string.Empty;
        [Required]
        [MinLength(6)]
        [Column("body")]
        public string Body { get; set; } = string.Empty;
        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        public string Slug { get; set; } = string.Empty;
        [Column("create_date")]
        public DateTime CreateDate { get; set; }
        [Column("last_update_date")]
        public DateTime LastUpdateDate { get; set; }

        [Required]
        [Column("category_id")]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        [Column("author_id")]
        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public User Author { get; set; } = null!;
    }
}