using StudentManagementSystem.Application.Interfaces.Repositories;
using StudentManagementSystem.Application.Interfaces.UnitOfWork;
using StudentManagementSystem.Infrastructure.Data;
using StudentManagementSystem.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StudentManagementSystemDbContext _context;

        public UnitOfWork(StudentManagementSystemDbContext context)
        {
            _context = context;
        }

        public IEnrolmentRepository EnrolmentRepository => throw new NotImplementedException();

        public IStudentRepository StudentRepository => throw new NotImplementedException();

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }
    }
}
