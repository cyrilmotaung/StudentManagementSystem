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
    public class EnrolmentService : IEnrolmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EnrolmentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddEnrolmentAsync(Enrolment enrolment)
        {
            await _unitOfWork.EnrolmentRepository.AddAsync(enrolment);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteEnrolmentAsync(int id)
        {
            await _unitOfWork.EnrolmentRepository.DeleteAsync(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Enrolment>> GetAllEnrolmentsAsync()
        {
            return await _unitOfWork.EnrolmentRepository.GetAllAsync();
        }

        public async Task<Enrolment> GetEnrolmentByIdAsync(int id)
        {
            return await _unitOfWork.EnrolmentRepository.GetByIdAsync(id);
        }

        public async Task UpdateEnrolmentAsync(Enrolment enrolment)
        {
            await _unitOfWork.EnrolmentRepository.UpdateAsync(enrolment);
            await _unitOfWork.CommitAsync();
        }
    }
}
