using HospitalManagementSystem.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.DataAccess.Configurations;
internal sealed class AppUserAppRoleConfiguration : IEntityTypeConfiguration<AppUserAppRole>
{
    public void Configure(EntityTypeBuilder<AppUserAppRole> builder)
    {
        builder.ToTable("UserRoles");
        builder.HasKey(x => new { x.AppUserId, x.AppRoleId });
    }
}
