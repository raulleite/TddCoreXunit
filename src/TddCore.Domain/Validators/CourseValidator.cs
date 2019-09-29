using FluentValidation;
using TddCore.Domain.Entities;

namespace TddCore.Domain.Validators
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(course => course.Name)
                .NotEmpty()
                .WithMessage("Invalid Name");

            RuleFor(course => course.Workload)
                .GreaterThan(0)
                .WithMessage("Workload must be greater than 0");
        }
    }
}