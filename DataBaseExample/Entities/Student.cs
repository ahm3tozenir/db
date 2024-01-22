using System;
namespace DataBaseExample.Entities
{
  public class Student
  {
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Number { get; set; }
    public byte Marks { get; set; }
    public byte Absenteeism { get; set; }
    public virtual User User { get; set; }
  }
}

