using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBlog.Models;

public class Post
{
    public int Id { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string? Title { get; set; }

    [Required]
    public string? Content { get; set; }

    public DateTime Date { get; set; }

    public int LikesCount { get; set; }

    public int? CategoryId { get; set; }

    [ForeignKey("CategoryId")]
    public Category? Category { get; set; }

    public ApplicationUser? User { get; set; }
}

