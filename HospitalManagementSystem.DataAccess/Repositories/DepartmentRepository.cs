using HospitalManagementSystem.DataAccess.Context;
using HospitalManagementSystem.Entities.Models;
using HospitalManagementSystem.Entities.Repositories;

namespace HospitalManagementSystem.DataAccess.Repositories;

internal sealed class DepartmentRepository : Repository<Department>, IDepartmentRepository
{
    public DepartmentRepository(ApplicationDbContext context) : base(context)
    {
    }
}


