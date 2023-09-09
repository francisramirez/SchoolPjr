
using System.ComponentModel.DataAnnotations;

namespace SchoolPjr.DAL.Entities
{
    public class StudentGrade
    {

        [Key]
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public decimal? Grade { get; set; }
    }
}
