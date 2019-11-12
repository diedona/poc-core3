using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.POCCore3.Shared.Entities
{
    public abstract class Entity
    {
        protected IValidator _validator;
        protected ValidationResult _validationResult;
        private List<ValidationFailure> _customErrors;

        public Guid Id { get; protected set; }
        public bool Status { get; protected set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
            _validationResult = new ValidationResult();
            _customErrors = new List<ValidationFailure>();
        }

        protected void AddError(string propertyName, string errorMsg)
        {
            _customErrors.Add(new ValidationFailure(propertyName, errorMsg));
        }

        public bool IsValid()
        {
            if(_validator != null)
            {
                _validationResult = _validator.Validate(this);
            }

            AddCustomErrorsToValidationResult();            
            return _validationResult.IsValid;
        }

        public IList<ValidationFailure> GetErrors()
        {
            return _validationResult.Errors;
        }

        private void AddCustomErrorsToValidationResult()
        {
            foreach (var error in _customErrors)
            {
                _validationResult.Errors.Add(error);
            }
        }
    }
}
