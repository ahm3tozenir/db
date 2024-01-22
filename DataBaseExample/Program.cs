// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using DatabaseExample.Repositories;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


ExampleDbContext db = new();
db.Users.Add(new DatabaseExample.Entities.User { FirstName = "a", lastNam = "s", IdentificationNumber = "1231241", IsActive = true, Password = "1234", UserName = "asd123" });
db.Jobbers.Add(new DatabaseExample.Entities.Jobber { })
db.SaveChanges();e
var user = db.Users.FirstOrDefault();
Console.WriteLine(JsonConvert.SerializeObject(user));
Console.ReadLine();
