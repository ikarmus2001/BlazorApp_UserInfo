using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp_UserInfo.Data.Model;

[PrimaryKey(nameof(PropertyId), nameof(UserId))]
public class UserProperties
{
    
    [Required]
    public int PropertyId { get; set; }

    [Required] 
    public int UserId { get; set; }

    [Required]
    public string Value { get; set; } = string.Empty;
}
