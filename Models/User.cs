using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    [Table("user")]
    public class User
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
        [MaxLength(200)]
        [Column("email")]
        public string Email { get; set; } = string.Empty;
        [Required]
        [MinLength(3)]
        [MaxLength(255)]
        [Column("password_hash")]
        public string PasswordHash { get; set; } = string.Empty;
        [Required]
        [MinLength(3)]
        [Column("bio")]
        public string Bio { get; set; } = string.Empty;
        [Required]
        [MinLength(10)]
        [MaxLength(2000)]
        [Column("image")]
        public string Image { get; set; } = string.Empty;
        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("slug")]
        public string Slug { get; set; } = string.Empty;
    }
}