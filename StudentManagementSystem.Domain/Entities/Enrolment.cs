using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Domain.Entities
{
    public class Enrolment //: BaseEntity
    {
        public int EnrolmentId { get; set; }
        public string Institution { get; set; }
        public string Qualification { get; set; }
        public string QualificationType { get; set; } // can be enum
        public DateTime GraduationDate { get; set; }
        public int AverageToDate { get; set; }
        public int StudentId { get; set; }

        public Student Student { get; set; }
    }
}
