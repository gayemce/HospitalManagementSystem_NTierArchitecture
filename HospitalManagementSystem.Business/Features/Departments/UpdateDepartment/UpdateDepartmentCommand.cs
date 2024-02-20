using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Business.Features.Departments.UpdateDepartment;

public sealed record UpdateDepartmentCommand(
    Guid Id,
    string Name) : IRequest;