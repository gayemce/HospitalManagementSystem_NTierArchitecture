using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Business.Features.Departments.CreateDepartments;
public sealed record CreateDepartmentCommand(
    string Name) : IRequest;
