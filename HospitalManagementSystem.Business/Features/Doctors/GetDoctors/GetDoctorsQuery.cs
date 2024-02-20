using HospitalManagementSystem.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Business.Features.Doctors.GetDoctors;
public sealed record GetDoctorsQuery() : IRequest<List<Doctor>>;
