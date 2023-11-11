using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string Content { get; set; } = string.Empty;
    }
}
