using StudentManagementSystem.Application.Interfaces.Services;
using StudentManagementSystem.Application.Interfaces.UnitOfWork;
using StudentManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddStudentAsync(Student student)
        {
            await _unitOfWork.StudentRepository.AddAsync(student);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteStudentAsync(Student student)
        {
            await _unitOfWork.StudentRepository.DeleteAsync(student);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _unitOfWork.StudentRepository.GetAllAsync();
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await _unitOfWork.StudentRepository.GetByIdAsync(id);
        }

        public async Task UpdateStudentAsync(Student student)
        {
            await _unitOfWork.StudentRepository.UpdateAsync(student);
            await _unitOfWork.CommitAsync();
        }
    }
}
