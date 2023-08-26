
using System;
using System.Collections.Generic;
using System.Linq;

using SchoolPjr.DAL.Entities;
using SchoolPjr.DAL.Exceptions;
using SchoolPjr.DAL.Interfaces;
using SchoolPjr.DAL.Models;


namespace SchoolPjr.DAL.Dao
{
    public class DaoDepartment : IDaoDepartment
    {
        private readonly SchoolContext context;
        public DaoDepartment(SchoolContext context)
        {
            this.context = context;
        }
        public DepartmentModel GetDepartment(int DepartmentId)
        {
            DepartmentModel department = new DepartmentModel();

            try
            {
                var dep = context.Departments.Find(DepartmentId);

                department.DepartmentID = dep.DepartmentID;
                department.Budget = dep.Budget;
                department.CreationDate = dep.CreationDate;
                department.Name = dep.Name;
                department.StartDate = dep.StartDate;

            }
            catch (Exception ex)
            {
                throw new DepartmentDaoException($"Ocurrió el error: {ex.Message} obteniendo el departamento.");
            }

            return department;
        }

        public List<DepartmentModel> GetDepartments()
        {
            List<DepartmentModel> departments = new List<DepartmentModel>();

            try
            {
                departments = context.Departments.Select(dep => new DepartmentModel()
                {
                    Budget = dep.Budget,
                    CreationDate = dep.CreationDate,
                    DepartmentID = dep.DepartmentID,
                    Name = dep.Name,
                    StartDate = dep.StartDate
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new DepartmentDaoException($"Ocurrió el error: {ex.Message} obteniendo los departamentos.");
            }

            return departments;
        }

        public void Modify(Department department)
        {
            try
            {
                // Buscar el depto. que vamos a modificar.

                Department deptoToModify = context.Departments.Find(department.DepartmentID);


                if (deptoToModify is null)
                    throw new DepartmentDaoException($"El departamento { department.Name } no ha sido encontrado.");


                deptoToModify.ModifyDate = DateTime.Now;
                deptoToModify.UserMod = department.UserMod;
                deptoToModify.Name = department.Name;
                deptoToModify.StartDate = department.StartDate;
                deptoToModify.Administrator = deptoToModify.Administrator;

                context.Departments.Update(deptoToModify);
                context.SaveChanges();



            }
            catch (Exception ex)
            {

                throw new DepartmentDaoException($"Ocurrió el error: {ex.Message} actualizando el departamento.");
            }
        }

        public void Save(Department department)
        {
            try
            {
                if (department is null)
                    throw new DepartmentDaoException($"El departamento esta nulo.");


                context.Departments.Add(department);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new DepartmentDaoException($"Ocurrió el error: {ex.Message} guardando el departamento.");

            }
        }
    }
}
