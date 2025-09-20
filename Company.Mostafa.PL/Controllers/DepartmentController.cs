using Company.Mostafa.BLL.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Company.Mostafa.PL.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly DepartmentRepo _departmentRepo;

        public DepartmentController(DepartmentRepo departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var Department = _departmentRepo.GetAll();

            return View(Department);
        }
    }
}
