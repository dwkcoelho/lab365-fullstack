using Microsoft.AspNetCore.Mvc;

namespace standardRest.Controllers;

[ApiController]
[Route("[controller]")]

public class StudentController : ControllerBase
{

  [HttpGet]
  [Route("find-student")]
  public IActionResult FindStudent() {

    var firstStudent = new Student();
        firstStudent.Id = 1; 
        firstStudent.Name = "João";
        firstStudent.DateOfBirth = new DateTime(1998,10,10);

        return Ok(firstStudent);
  }
}