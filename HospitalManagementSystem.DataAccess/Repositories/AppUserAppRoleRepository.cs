using HospitalManagementSystem.DataAccess.Context;
using HospitalManagementSystem.Entities.Models;
using HospitalManagementSystem.Entities.Repositories;

namespace HospitalManagementSystem.DataAccess.Repositories;

internal sealed class AppUserAppRoleRepository : Repository<AppUserAppRole>, IAppUserAppRoleRepository
{
    public AppUserAppRoleRepository(ApplicationDbContext context) : base(context)
    {
    }
}


