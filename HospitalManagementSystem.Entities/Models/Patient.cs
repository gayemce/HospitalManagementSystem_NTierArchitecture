using HospitalManagementSystem.Entities.Abstractions;

namespace HospitalManagementSystem.Entities.Models;

public sealed class Patient : Entity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName => string.Join(" ", this.FirstName, this.LastName);
    public string IdentityNumber {  get; set; } = string.Empty;
}