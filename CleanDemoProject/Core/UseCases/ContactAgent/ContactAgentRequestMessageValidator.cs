using FluentValidation;

namespace CleanDemoProject.Core.UseCases.ContactAgent
{
    public class ContactAgentRequestMessageValidator : AbstractValidator<ContactAgentRequestMessage>
    {
        public ContactAgentRequestMessageValidator()
        {
            RuleFor(r => r.CustomerEmailAddress).NotEmpty();
            RuleFor(r => r.CustomerEmailAddress).EmailAddress().WithMessage("Not a valid email address");
        }
    }
}
