using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Business.Features.Doctors.CreateDoctor;
internal sealed class CreateDoctorValidator : AbstractValidator<CreateDoctorCommand>
{
    public CreateDoctorValidator()
    {
        RuleFor(p => p.FirstName).NotEmpty().WithMessage("Doktor adı boş olamaz");
        RuleFor(p => p.FirstName).MinimumLength(3).WithMessage("Doktor adı en az 3 karakter olmalıdır");
        RuleFor(p => p.LastName).NotEmpty().WithMessage("Doktor soyadı adı boş olamaz");
        RuleFor(p => p.LastName).MinimumLength(3).WithMessage("Doktor soyadı en az 3 karakter olmalıdır");
        RuleFor(p => p.IdentityNumber).NotEmpty().WithMessage("Doktor kimlik numara alanı boş olamaz");
        RuleFor(p => p.IdentityNumber).MinimumLength(11).MaximumLength(11).WithMessage("Doktor kimlik numara alanı 11 karakter olmalıdır");
        RuleFor(p => p.DepartmentId).NotEmpty().WithMessage("Doktor bölüm alanı boş olamaz");
    }
}
