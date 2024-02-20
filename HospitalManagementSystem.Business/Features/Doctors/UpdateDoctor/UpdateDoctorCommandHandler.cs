using HospitalManagementSystem.Entities.Models;
using HospitalManagementSystem.Entities.Repositories;
using MediatR;

namespace HospitalManagementSystem.Business.Features.Doctors.UpdateDoctor;

internal sealed class UpdateDoctorCommandHandler : IRequestHandler<UpdateDoctorCommand>
{
    private readonly IDoctorRepository _doctorRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateDoctorCommandHandler(IDoctorRepository doctorRepository, IUnitOfWork unitOfWork)
    {
        _doctorRepository = doctorRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(UpdateDoctorCommand request, CancellationToken cancellationToken)
    {
        Doctor doctor = await _doctorRepository.GetByIdAsync(p => p.Id == request.Id, cancellationToken);
        if(doctor is null)
        {
            throw new ArgumentNullException("Doktor bulunamadı!");
        }

        if(doctor.IdentityNumber != request.IdentityNumber)
        {
            var isIdentityNumberExists = await _doctorRepository.AnyAsync(p => p.IdentityNumber == request.IdentityNumber, cancellationToken);

            if (isIdentityNumberExists)
            {
                throw new ArgumentException("Bu kimlik numarasına sahip doktor zaten sistemde mevcut!");
            }
        }

        doctor.FirstName = request.FirstName;
        doctor.LastName = request.LastName;
        doctor.IdentityNumber = request.IdentityNumber;
        doctor.DepartmentId = request.DepartmentId;

        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
