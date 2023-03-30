using StudentManagementSystem.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        IEnrolmentRepository EnrolmentRepository { get; }
        IStudentRepository StudentRepository { get; }
        Task CommitAsync();
    }
}
