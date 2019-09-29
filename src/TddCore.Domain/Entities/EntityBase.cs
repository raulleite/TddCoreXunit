using System;
using FluentValidation;
using FluentValidation.Results;

namespace TddCore.Domain.Entities
{
    public class EntityBase
    {
        public Guid Id { get; protected set; }
        public bool Valid { get; private set; }
        public bool Invalid => !Valid;
        public ValidationResult ValidationResult { get; private set;}

        protected EntityBase()
        {
            SetId(Guid.NewGuid());
        }
        public void SetId(Guid id) => Id = id;
        public bool Validate<TEntity>(
            TEntity entity, 
            AbstractValidator<TEntity> abstractValidator)
        {
            ValidationResult = abstractValidator.Validate(entity);

            return Valid = ValidationResult.IsValid;
        }
    }
}