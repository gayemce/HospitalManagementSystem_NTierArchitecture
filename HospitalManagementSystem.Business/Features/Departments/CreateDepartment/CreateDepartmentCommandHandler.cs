using HospitalManagementSystem.Business.Features.Doctors.CreateDoctor;
using HospitalManagementSystem.Entities.Models;
using HospitalManagementSystem.Entities.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Business.Features.Departments.CreateDepartments;

internal sealed class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand>
{
    private readonly IDepartmentRepository _departmentRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateDepartmentCommandHandler(IDepartmentRepository departmentRepository, IUnitOfWork unitOfWork)
    {
        _departmentRepository = departmentRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
    {
        var isNameExists = await _departmentRepository.AnyAsync(p => p.Name == request.Name, cancellationToken);

        if (isNameExists)
        {
            throw new ArgumentException("Bu bölüm sistemde mevcut!");
        }

        Department department = new()
        {
            Name = request.Name,
        };

        await _departmentRepository.AddAsync(department, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}