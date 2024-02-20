using HospitalManagementSystem.Entities.Abstractions;

namespace HospitalManagementSystem.Entities.Models;

public sealed class Nurse : Entity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName => string.Join(" ", this.FirstName, this.LastName);
    public string IdentityNumber { get; set; } = string.Empty;
    public Guid? DepartmentId { get; set; }
    public Department? Department { get; set; }
}