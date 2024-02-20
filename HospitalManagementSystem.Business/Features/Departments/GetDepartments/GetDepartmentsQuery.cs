using HospitalManagementSystem.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Business.Features.Departments.GetDepartments;
public sealed record GetDepartmentsQuery() : IRequest<List<Department>>;