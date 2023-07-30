using System.ComponentModel.DataAnnotations;

namespace MyBlog.Models;

public class Follower
{
    public int Id { get; set; }
    public ApplicationUser? User { get; set; }
    public ApplicationUser? FollowerUser { get; set; }
}
