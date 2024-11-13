using EMS.Models;
using EMS.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public IEmployeeService _employeeServices { get; }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(EmployeeVm vm)
        {
            var dto = new EmployeeDto();
            dto.Address = vm.Address;
            dto.Name = vm.Name;
            dto.Contact = vm.Contact;

            _employeeService.Create(dto);
            return RedirectToAction("Index");

        }

    }
}
