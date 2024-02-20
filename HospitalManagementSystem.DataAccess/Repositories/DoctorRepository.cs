using HospitalManagementSystem.DataAccess.Context;
using HospitalManagementSystem.Entities.Models;
using HospitalManagementSystem.Entities.Repositories;

namespace HospitalManagementSystem.DataAccess.Repositories;

internal sealed class DoctorRepository : Repository<Doctor>, IDoctorRepository
{
    public DoctorRepository(ApplicationDbContext context) : base(context)
    {
    }
}


