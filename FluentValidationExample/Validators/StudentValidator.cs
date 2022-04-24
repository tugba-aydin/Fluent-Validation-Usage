using FluentValidation;
using FluentValidationExample.Entities;

namespace FluentValidationExample.Validators
{
    public class StudentValidator:AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(s => s.Name).NotNull();
            RuleFor(s => s.Surname).NotNull();
            RuleFor(s => s.Age).GreaterThan(6);
            RuleFor(s => s.Address).MinimumLength(15);
        }
    }
}
