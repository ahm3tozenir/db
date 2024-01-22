using System;
namespace DataBaseExample.Entities
{
  public class Jobber
  {
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Plate { get; set; }
    public string WorkArea { get; set; }
    public virtual User User { get; set; }
  }
}

