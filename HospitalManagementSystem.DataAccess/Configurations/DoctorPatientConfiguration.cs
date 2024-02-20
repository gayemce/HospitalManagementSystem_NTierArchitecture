using HospitalManagementSystem.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DataAccess.Configurations;
internal sealed class DoctorPatientConfiguration : IEntityTypeConfiguration<DoctorPatient>
{
    public void Configure(EntityTypeBuilder<DoctorPatient> builder)
    {
        builder.ToTable("DoctorPatients");
        builder.HasKey(x => new { x.DoctorId, x.PatientId });
    }
}
