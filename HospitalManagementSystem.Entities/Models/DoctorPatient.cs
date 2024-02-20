namespace HospitalManagementSystem.Entities.Models;

public sealed class DoctorPatient
{
    public Guid DoctorId { get; set; }
    public Doctor? Doctor { get; set; }
    public Guid PatientId { get; set;}
    public Patient? Patient { get; set;}
}