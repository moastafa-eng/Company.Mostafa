using Company.Mostafa.BLL.Interfaces;
using Company.Mostafa.DAL.Data.Context;
using Company.Mostafa.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Mostafa.BLL.Repos
{
    public class DepartmentRepo : IDepartmentRepo
    {

        private readonly CompanyDBContext _Context;

        public DepartmentRepo(CompanyDBContext Context)
        {
            _Context = new CompanyDBContext();
        }
        public int Add(Department Model)
        {
            _Context.Departments.Add(Model);
            return _Context.SaveChanges();
        }

        public int Delete(Department Model)
        {
            _Context.Departments.Remove(Model);
            return _Context.SaveChanges();
        }

        public Department? Get(int Id)
        {
            return _Context.Departments.Find();
        }

        public IEnumerable<Department> GetAll()
        {
            return _Context.Departments.ToList();
        }

        public int Update(Department Model)
        {
            _Context.Departments.Update(Model);
            return _Context.SaveChanges();
        }
    }
}
