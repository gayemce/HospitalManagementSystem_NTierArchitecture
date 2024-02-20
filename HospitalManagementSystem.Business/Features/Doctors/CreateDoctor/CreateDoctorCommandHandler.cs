using HospitalManagementSystem.Entities.Models;
using HospitalManagementSystem.Entities.Repositories;
using MediatR;

namespace HospitalManagementSystem.Business.Features.Doctors.CreateDoctor;

internal sealed class CreateDoctorCommandHandler : IRequestHandler<CreateDoctorCommand>
{
    private readonly IDoctorRepository _doctorRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateDoctorCommandHandler(IDoctorRepository doctorRepository, IUnitOfWork unitOfWork)
    {
        _doctorRepository = doctorRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(CreateDoctorCommand request, CancellationToken cancellationToken)
    {
        var isIdentityNumberExists = await _doctorRepository.AnyAsync(p => p.IdentityNumber == request.IdentityNumber, cancellationToken);

        if(isIdentityNumberExists)
        {
            throw new ArgumentException("Bu kimlik numarasına sahip doktor zaten sistemde mevcut!");
        }

        Doctor doctor = new()
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            IdentityNumber = request.IdentityNumber,
            DepartmentId = request.DepartmentId
        };

        await _doctorRepository.AddAsync(doctor, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
