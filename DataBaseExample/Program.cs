// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using DatabaseExample.Repositories;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


ExampleDbContext db = new();
//10 tane aynı user'dan gelen hem student hem personal hem jobber olan
for (int i = 1; i < 11; i++)
{
    User commonUser = new User()
    {
        FirstName = "CFirstName" + i,
        LastName = "CLastName" + i,
        UserName = "Cuser" + i,
        Password = "1234",
        IsActive = true,
        IdentificationNumber = "CTC" + i
    };

    
    Personal personal = new Personal()
    {
        UserId = commonUser.UserId,
        Salary = 100 + (i * i),
        SSN = "SSN" + i,
        User = commonUser
    };

    
    Student student = new Student()
    {
        UserId = commonUser.UserId,
        StudentNumber = "S" + i,
        Department = "Department" + i,
        Marks = (byte)(1 + i), 
        Absenteeism = (byte)(1 + i),
        User = commonUser
    };

  
    Jobber jobber = new Jobber()
    {
        UserId = commonUser.UserId,
        Plate = "Plate" + i,
        WorkArea = "WorkArea" + i,
        User = commonUser
    };
  
    db.Users.Add(commonUser);
    db.Personals.Add(personal);
    db.Students.Add(student);
    db.Jobbers.Add(jobber);
}

//90 tane personal
for (int i = 12; i < 103; i++)
{
    User newUser = new User()
    {
        FirstName = "PersonalFirstName" + i,
        LastName = "PersonalLastName" + i,
        UserName = "PersonalUser" + i,
        Password = "1234" + i,
        IsActive = true,
        IdentificationNumber = "PersonalTC" + i
    };

    Personal personal = new Personal()
    {
        UserId = newUser.UserId,
        Salary = 100 + (i * i),
        SSN = "SSN" + i,
        User = newUser
    };

    db.Users.Add(newUser);
    db.Personals.Add(personal);
}
//90 tane student
for (int i = 12; i < 103; i++)
{
    User newUser = new User()
    {
        FirstName = "StudentFirstName" + i,
        LastName = "StudentLastName" + i,
        UserName = "student" + i,
        Password = "1234",
        IsActive = true,
        IdentificationNumber = "StudentTC" + i
    };

    Student student = new Student()
    {
        UserId = newUser.UserId,
        StudentNumber = "S" + i,
        Department = "Department" + i,
        Marks = (byte)(1 + i), 
        Absenteeism = (byte)(1 + i),
        User = newUser
    };

    db.Users.Add(newUser);
    db.Students.Add(student);
}
//90  tane jobber
for (int i = 12; i < 103; i++)
{
    User newUser = new User()
    {
        FirstName = "JobberFirstName" + i,
        LastName = "JobberLastName" + i,
        UserName = "jobber" + i,
        Password = "1234",
        IsActive = true,
        IdentificationNumber = "JobberTC" + i
    };

    Jobber jobber = new Jobber()
    {
        UserId = newUser.UserId,
        Plate = "Plate" + i,
        WorkArea = "WorkArea" + i,
        User = newUser
    };

    db.Users.Add(newUser);
    db.Jobbers.Add(jobber);
}

Console.ReadLine();
