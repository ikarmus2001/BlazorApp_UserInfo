﻿using BlazorApp_UserInfo.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp_UserInfo;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<AppUser> Users { get; set; }
}