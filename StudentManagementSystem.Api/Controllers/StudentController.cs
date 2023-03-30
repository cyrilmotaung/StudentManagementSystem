using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Application.Interfaces.Services;
using StudentManagementSystem.Domain.Entities;

namespace StudentManagementSystem.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IEnumerable<Student>> Get()
        {
            return await _studentService.GetAllStudentsAsync();
        }

        [HttpGet("{id}")]
        public async Task<Student> GetById(int id)
        {
            return await _studentService.GetStudentByIdAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<Student>> Post(Student student)
        {
             await _studentService.AddStudentAsync(student);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Student student)
        {
            if (id != student.StudentId)
            {
                return BadRequest();
            }

            await _studentService.UpdateStudentAsync(student);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var student = await _studentService.GetStudentByIdAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            await _studentService.DeleteStudentAsync(student);

            return NoContent();
        }
    }
}

