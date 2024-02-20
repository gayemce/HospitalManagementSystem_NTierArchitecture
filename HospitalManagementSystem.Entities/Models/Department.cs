using HospitalManagementSystem.Entities.Abstractions;

namespace HospitalManagementSystem.Entities.Models;

public sealed class Department : Entity
{
    public string Name { get; set; } = string.Empty;
    public List<Doctor>? Doctors { get; set; }
}