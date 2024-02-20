using HospitalManagementSystem.Business.Features.Departments.RemoveDepartment;
using HospitalManagementSystem.Entities.Models;
using HospitalManagementSystem.Entities.Repositories;
using MediatR;

namespace HospitalManagementSystem.Business.Features.Departments.RemoveByIdDepartment;

internal sealed class RemoveDepartmentByIdCommandHandler : IRequestHandler<RemoveDepartmentByIdCommand>
{
    private readonly IDepartmentRepository _departmentRepository;
    private readonly IUnitOfWork _unitOfWork;
    public RemoveDepartmentByIdCommandHandler(IDepartmentRepository departmentRepository, IUnitOfWork unitOfWork)
    {
        _departmentRepository = departmentRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoveDepartmentByIdCommand request, CancellationToken cancellationToken)
    {
        Department department = await _departmentRepository.GetByIdAsync(p => p.Id == request.Id, cancellationToken);
        if (department is null)
        {
            throw new ArgumentException("Bölüm bulunamadı!");
        }

        _departmentRepository.Remove(department);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
