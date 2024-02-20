using HospitalManagementSystem.Entities.Models;
using HospitalManagementSystem.Entities.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Business.Features.Departments.GetDepartments;

internal sealed class GetDepartmentsQueryHandler : IRequestHandler<GetDepartmentsQuery, List<Department>>
{
    private readonly IDepartmentRepository _departmentRepository;

    public GetDepartmentsQueryHandler(IDepartmentRepository departmentRepository)
    {
        _departmentRepository = departmentRepository;
    }
    public async Task<List<Department>> Handle(GetDepartmentsQuery request, CancellationToken cancellationToken)
    {
        return await _departmentRepository.GetAll().OrderBy(p => p.Name).ToListAsync(cancellationToken);
    }
}
