using HospitalManagementSystem.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DataAccess.Configurations;
internal sealed class NurseConfiguration : IEntityTypeConfiguration<Nurse>
{
    public void Configure(EntityTypeBuilder<Nurse> builder)
    {
        builder.ToTable("Nurses");
        builder.HasKey(x => x.Id);
        builder.Property(p => p.FirstName).HasColumnType("varchar(25)");
        builder.Property(p => p.LastName).HasColumnType("varchar(25)");
        builder.Property(p => p.IdentityNumber).HasColumnType("varchar(11)");
    }
}
