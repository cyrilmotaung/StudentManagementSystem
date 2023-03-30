using StudentManagementSystem.Application.Interfaces.Repositories;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Infrastructure.Repositories
{
    public class EnrolmentRepository : GenericRepository<Enrolment>, IEnrolmentRepository
    {
        public EnrolmentRepository(StudentManagementSystemDbContext context) : base(context)
        {
        }
        public Task AddAsync(Enrolment entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Enrolment>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Enrolment> GetByIdAsync(int id)
        {
            return await Enrolments.Where(e => e.Id == Id).ToListAsync();
        }

        public Task UpdateAsync(Enrolment entity)
        {
            throw new NotImplementedException();
        }
    }
}
