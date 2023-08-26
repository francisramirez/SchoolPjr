

using SchoolPjr.DAL.Entities;
using SchoolPjr.DAL.Models;
using System.Collections.Generic;

namespace SchoolPjr.DAL.Interfaces
{
    public interface IDaoDepartment
    {
        void Save(Department department);
        void Modify(Department department);
        List<DepartmentModel> GetDepartments();

       DepartmentModel GetDepartment(int DepartmentId);

     
       
    }
}
