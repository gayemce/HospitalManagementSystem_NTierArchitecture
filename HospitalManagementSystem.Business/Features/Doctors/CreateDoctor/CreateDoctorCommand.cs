using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Business.Features.Doctors.CreateDoctor;
public sealed record CreateDoctorCommand(
    string FirstName,
    string LastName,
    string IdentityNumber,
    Guid DepartmentId) : IRequest;
