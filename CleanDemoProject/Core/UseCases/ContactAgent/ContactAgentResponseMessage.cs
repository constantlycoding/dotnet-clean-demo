using FluentValidation;
using FluentValidation.Results;

namespace CleanDemoProject.Core.UseCases.ContactAgent
{
    public class ContactAgentResponseMessage
    {
        public ValidationResult ValidationResult { get; }
        public long? HouseId { get; private set; } //the response object needs this information, so the user knows which object we're talking about;

        public ContactAgentResponseMessage(ValidationResult validationResult, int? houseId = null)
        {
            HouseId = houseId;
            ValidationResult = validationResult;
        }
    }
}
