using HospitalManagementSystem.DataAccess.Context;
using HospitalManagementSystem.Entities.Models;
using HospitalManagementSystem.Entities.Repositories;

namespace HospitalManagementSystem.DataAccess.Repositories;

internal sealed class NurseRepository : Repository<Nurse>, INurseRepository
{
    public NurseRepository(ApplicationDbContext context) : base(context)
    {
    }
}


