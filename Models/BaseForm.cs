/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using FluentValidation.Results;

namespace cms.Models
{
    public abstract class BaseForm
    {
        public ValidationResult ValidationResults { get; set; }
        public bool HasValidationError { get => !ValidationResults.IsValid; }
        public abstract bool Validate();
    }
}
