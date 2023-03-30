using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using school.Dtos;
using school.Repositories;

namespace school.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubjectController : ControllerBase
    {

        [HttpGet]
        [Route("show")]
        public IActionResult Show([FromQuery] string? name)
        {
           
            var repository = new SubjectRepository();
            var subjects = repository.ShowSubjects(name);

            return Ok(subjects);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id deve ser maior que zero");
            }
            var repository = new SubjectRepository();
            var subject = repository.GetSubject(id);

            if (subject == null)
            {
                return NotFound();
            }
            return Ok(subject);
        }
        [HttpPost]
        [Route("add")]
        public IActionResult AddSub([FromBody] SubjectDto dto)
        {
            var repository = new SubjectRepository();
            var subject = repository.AddSubject(dto);

            return CreatedAtAction(nameof(SubjectController.Get), new { id = subject.Id }, subject);
        }
        [HttpPatch]
        [Route("{id}")]
        public IActionResult Update(int id, [FromForm] SubjectDto dto)
        {
            var repository = new SubjectRepository();
            var subject = repository.AlterSubject(id, dto);
            return Ok(subject);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var repository = new SubjectRepository();
            repository.DeleteSubject(id); 

            return NoContent();
        }
    }
}
