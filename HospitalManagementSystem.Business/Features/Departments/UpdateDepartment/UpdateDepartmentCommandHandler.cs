using HospitalManagementSystem.Business.Features.Doctors.UpdateDoctor;
using HospitalManagementSystem.Entities.Models;
using HospitalManagementSystem.Entities.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Business.Features.Departments.UpdateDepartment;

internal sealed class UpdateDepartmentCommandHandler : IRequestHandler<UpdateDepartmentCommand>
{
    private readonly IDepartmentRepository _departmentRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateDepartmentCommandHandler(IDepartmentRepository departmentRepository, IUnitOfWork unitOfWork)
    {
        _departmentRepository = departmentRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
    {
        Department department = await _departmentRepository.GetByIdAsync(p => p.Id == request.Id, cancellationToken);
        if (department is null)
        {
            throw new ArgumentNullException("Bölüm bulunamadı!");
        }

        if (department.Name != request.Name)
        {
            var isIdentityNumberExists = await _departmentRepository.AnyAsync(p => p.Name == request.Name, cancellationToken);

            if (isIdentityNumberExists)
            {
                throw new ArgumentException("Bu bölüm sistemde mevcut!");
            }
        }

        department.Name = request.Name;

        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
