using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using school.Dtos;
using school.Models;
using school.Repositories;

namespace school.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("show")]
        public IActionResult Show([FromQuery] string? name)
        {
            var repository = new StudentRepository();
            var students = repository.ShowStudents(name);

            return Ok(students);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id deve ser maior que zero");
            }
            var repository = new StudentRepository();
            var student = repository.GetStudent(id);

            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
        [HttpPost]
        [Route("add")]
        public IActionResult AddStu([FromBody] StudentDto dto)
        {
            var repository = new StudentRepository();
            var student = repository.AddStudent(dto);

            return CreatedAtAction(nameof(StudentController.Get), new { id = student.Id }, student);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var repository = new StudentRepository();
            repository.DeleteStudent(id);

            return NoContent();
        }

    }
}
