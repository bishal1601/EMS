using EMS.Models;
using EMS.Services.Interfaces;
using EMS.Data;
namespace EMS.Services
{
    public class EmployeeService : IEmployeeService
    {
        public void Create(EmployeeDto dto)
        {
            dto.Id = Guid.NewGuid();
            Database.Employees.Add(dto);
        }
    }
}
