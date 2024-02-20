using HospitalManagementSystem.Business.Features.Doctors.CreateDoctor;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Business.Features.Doctors.UpdateDoctor;
public sealed record UpdateDoctorCommand(
    Guid Id,
    string FirstName,
    string LastName,
    string IdentityNumber,
    Guid DepartmentId) : IRequest;
