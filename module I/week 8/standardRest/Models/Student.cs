using Microsoft.AspNetCore.Mvc;
namespace standardRest;

public class Student
{
  public int Id { get; set; }
  public string Name { get; set; }
  public DateTime DateOfBirth { get; set; }
}