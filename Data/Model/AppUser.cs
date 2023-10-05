﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp_UserInfo.Data.Model;

public class AppUser
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    [StringLength(150)]
    public string Surname { get; set; }

    [Required]
    [StringLength(20)]
    public string Gender { get; set; }

    [DataType(DataType.Date)]
    public DateTime Birthdate { get; set; }
}