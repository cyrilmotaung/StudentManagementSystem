using StudentManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Application.Interfaces.Services
{
    public interface IEnrolmentService
    {
        Task<IEnumerable<Enrolment>> GetAllEnrolmentsAsync();
        Task<Enrolment> GetEnrolmentByIdAsync(int id);
        Task AddEnrolmentAsync(Enrolment enrolment);
        Task UpdateEnrolmentAsync(Enrolment enrolment);
        Task DeleteEnrolmentAsync(int id);
    }
}
