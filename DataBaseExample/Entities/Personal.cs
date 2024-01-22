using System;
namespace DataBaseExample.Entities
{
  public class Personal
  {
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public decimal Salary { get; set; }
    public string SSN { get; set; }
    public virtual User User { get; set; }
  }
}

