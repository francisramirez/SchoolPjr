

using SchoolPjr.DAL.Entities;
using SchoolPjr.DAL.Models;
using System.Collections.Generic;

namespace SchoolPjr.DAL.Interfaces
{
    public interface IDaoCourse
    {
        void Save(Course course);

        void Modify(Course department);
        List<CourseModel> GetCourses();

        List<CourseModel> GetCourses(int DepartmentId);
        CourseModel GetCourse(int DepartmentId);
    }
}
