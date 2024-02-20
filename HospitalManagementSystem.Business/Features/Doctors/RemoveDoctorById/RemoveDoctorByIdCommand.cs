using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Business.Features.Doctors.RemoveDoctorById;
public sealed record RemoveDoctorByIdCommand(
    Guid Id) : IRequest;