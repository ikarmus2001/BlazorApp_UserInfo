using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace BlazorApp_UserInfo.Data.Model;

public class AppUser
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(150)]
    public string Surname { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string Gender { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    public DateTime Birthdate { get; set; } = DateTime.MinValue;

    public string Title() => Gender.ToLower() switch
    {
        "male" => "Mr",
        "female" => "Ms",
        _ => "N/D"
    };

    internal string Age()
    {
        int age = DateTime.Now.Year - Birthdate.Year;
        if (DateTime.Now.DayOfYear < Birthdate.DayOfYear)
            age -= 1;
        return age.ToString();
    }
}
