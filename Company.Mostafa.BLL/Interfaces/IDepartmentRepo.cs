using Company.Mostafa.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Mostafa.BLL.Interfaces
{
    public interface IDepartmentRepo
    {
        IEnumerable<Department> GetAll();
        Department? Get(int Id);
        int Add(Department Model);
        int Update(Department Model);
        int Delete(Department Model);
    }
}
