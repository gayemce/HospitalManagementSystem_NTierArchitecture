using HospitalManagementSystem.DataAccess.Context;
using HospitalManagementSystem.Entities.Models;
using HospitalManagementSystem.Entities.Repositories;

namespace HospitalManagementSystem.DataAccess.Repositories;

internal sealed class DoctorPatientRepository : Repository<DoctorPatient>, IDoctorPatientRepository
{
    public DoctorPatientRepository(ApplicationDbContext context) : base(context)
    {
    }
}


