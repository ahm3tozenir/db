using System;
using DataBaseExample.Entities;
using Microsoft.EntityFrameworkCore;
namespace DataBaseExample.Repositories;

public class ExampleDbContext:DbContext
{
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlServer("Server=localhost;Database=Example;User Id=SA;TrustServerCertificate=True;Password=reallyStrongPwd123;");
  }
  public DbSet<User> Users { get; set; }
  public DbSet<Personal> Personals { get; set; }
  public DbSet<Student> Students { get; set; }
  public DbSet<Jobber> Jobbers { get; set; }

  
}

