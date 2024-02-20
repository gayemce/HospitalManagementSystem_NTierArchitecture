using HospitalManagementSystem.DataAccess.Context;
using HospitalManagementSystem.Entities.Models;
using HospitalManagementSystem.Entities.Repositories;

namespace HospitalManagementSystem.DataAccess.Repositories;

internal sealed class AppRoleRepository : Repository<AppRole>, IAppRoleRepository
{
    public AppRoleRepository(ApplicationDbContext context) : base(context)
    {
    }
}


