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

        public async Task<IActionResult> Index()
        {
            var enrolments = await _enrolmentService.GetAllEnrolmentsAsync();
            return View(enrolments);
        }

        public async Task<IActionResult> Details(int id)
        {
            var enrolment = await _enrolmentService.GetEnrolmentByIdAsync(id);
            return View(enrolment);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Enrolment enrolment)
        {
            if (ModelState.IsValid)
            {
                await _enrolmentService.AddEnrolmentAsync(enrolment);
                return RedirectToAction(nameof(Index));
            }

            return View(enrolment);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var enrolment = await _enrolmentService.GetEnrolmentByIdAsync(id);
            if (enrolment == null)
            {
                return NotFound();
            }

            return View(enrolment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Enrolment enrolment)
        {
            if (id != enrolment.EnrolmentId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _enrolmentService.UpdateEnrolmentAsync(enrolment);
                return RedirectToAction(nameof(Index));
            }

            return View(enrolment);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var enrolment = await _enrolmentService.GetEnrolmentByIdAsync(id);
            if (enrolment == null)
            {
                return NotFound();
            }

            return View(enrolment);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enrolment = await _enrolmentService.GetEnrolmentByIdAsync(id);
            if (enrolment == null)
            {
                return NotFound();
            }

            await _enrolmentService.DeleteEnrolmentAsync(enrolment);
            return RedirectToAction(nameof(Index));
        }
    }
}
