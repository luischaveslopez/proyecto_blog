using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace MyBlog.Models;

public class ApplicationUser : IdentityUser
{

    [Required]
    public string? FirstName { get; set; }

    [Required]
    public string? LastName { get; set; }
    public string? LastName2 { get; set; }
    public string? Location { get; set; }
    public DateTime SignUpDate { get; set; }
    public string? AccountStatus { get; set; }
    public int FollowersCount { get; set; }
    public int FollowingCount { get; set; }
    public string? Description { get; set; }
    public ICollection<Post>? Posts { get; set; }

}
