using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Application.Interfaces.Services;
using StudentManagementSystem.Domain.Entities;

namespace StudentManagementSystem.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrolmentController : ControllerBase
    {
        private readonly IEnrolmentService _enrolmentService;

        public EnrolmentController(IEnrolmentService enrolmentService)
        {
            _enrolmentService = enrolmentService;
        }

        [HttpGet]
        public async Task<IEnumerable<Enrolment>> Get()
        {
            return await _enrolmentService.GetAllEnrolmentsAsync();
        }

        [HttpGet("{id}")]
        public async Task<Enrolment> GetById(int id)
        {
            return await _enrolmentService.GetEnrolmentByIdAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<Enrolment>> Post(Enrolment enrolment)
        {
            await _enrolmentService.AddEnrolmentAsync(enrolment);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Enrolment enrolment)
        {
            if (id != enrolment.EnrolmentId)
            {
                return BadRequest();
            }

            await _enrolmentService.UpdateEnrolmentAsync(enrolment);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var enrolment = await _enrolmentService.GetEnrolmentByIdAsync(id);
            if (enrolment == null)
            {
                return NotFound();
            }

            await _enrolmentService.DeleteEnrolmentAsync(enrolment);

            return NoContent();
        }
    }
}
