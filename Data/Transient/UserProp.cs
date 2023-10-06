using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp_UserInfo.Data.Transient;

[NotMapped]
public class UserProp
{
    public int UserId { get; set; }
    public int PropertyId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Value { get; set; } = string.Empty;
}
