using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Domain.Entities
{
    public class Student //: BaseEntity
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string IdNumber { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string PreferredContactMethod { get; set; }
        public byte[] ProfileImage { get; set; }
        public ApplicationRole Role { get; set; }
        public ICollection<Enrolment> Enrolments { get; set; }
    }
}
