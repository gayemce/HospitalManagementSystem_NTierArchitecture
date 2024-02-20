using HospitalManagementSystem.Entities.Models;
using HospitalManagementSystem.Entities.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Business.Features.Doctors.GetDoctors;

internal sealed class GetDoctorsQueryHandler : IRequestHandler<GetDoctorsQuery, List<Doctor>>
{
    private readonly IDoctorRepository _doctorRepository;

    public GetDoctorsQueryHandler(IDoctorRepository doctorRepository)
    {
        _doctorRepository = doctorRepository;
    }
    public async Task<List<Doctor>> Handle(GetDoctorsQuery request, CancellationToken cancellationToken)
    {
        return await _doctorRepository.GetAll().OrderBy(p => p.FirstName).ToListAsync(cancellationToken);
    }
}
