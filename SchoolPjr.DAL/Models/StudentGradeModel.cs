

namespace SchoolPjr.DAL.Models
{
    public class StudentGradeModel
    {
        public int EnrollmentID { get; set; }

        public int StudentId { get; set; }

        public string? Student { get; set; }

        public int CourseId { get; set; }
        public string? Course { get; set; }

        public decimal? Grade { get; set; }
    }
}
