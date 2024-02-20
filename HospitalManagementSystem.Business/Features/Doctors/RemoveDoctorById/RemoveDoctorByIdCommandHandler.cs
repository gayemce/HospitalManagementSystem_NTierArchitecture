using HospitalManagementSystem.Entities.Models;
using HospitalManagementSystem.Entities.Repositories;
using MediatR;

namespace HospitalManagementSystem.Business.Features.Doctors.RemoveDoctorById;
internal sealed class RemoveDoctorByIdCommandHandler : IRequestHandler<RemoveDoctorByIdCommand>
{
    private readonly IDoctorRepository _doctorRepository;
    private readonly IUnitOfWork _unitOfWork;
    public RemoveDoctorByIdCommandHandler(IDoctorRepository doctorRepository, IUnitOfWork unitOfWork)
    {
        _doctorRepository = doctorRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoveDoctorByIdCommand request, CancellationToken cancellationToken)
    {
        Doctor doctor = await _doctorRepository.GetByIdAsync(p => p.Id == request.Id, cancellationToken);
        if (doctor is null)
        {
            throw new ArgumentException("Doktor bulunamadı!");
        }

        _doctorRepository.Remove(doctor);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
