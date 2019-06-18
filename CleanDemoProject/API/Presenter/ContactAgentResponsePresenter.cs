using CleanDemoProject.API.Models;
using CleanDemoProject.Core.UseCases.ContactAgent;
using System.Text;

namespace CleanDemoProject.API.Presenter
{
    public class ContactAgentResponsePresenter
    {
        public ContactAgentResponseViewModel Handle(ContactAgentResponseMessage responseMessage)
        {
            switch (responseMessage.ValidationResult.IsValid)
            {
                case true:
                    return new ContactAgentResponseViewModel("Thank you for your interest in this house, an agent will get back to you shortly");
                case false:
                    var sb = new StringBuilder();
                    sb.AppendLine("There was a problem with your input, please uncomment code from Program.cs, then try again.");

                    foreach (var error in responseMessage.ValidationResult.Errors)
                    {
                        sb.AppendLine(error.ErrorMessage);
                    }
                    return new ContactAgentResponseViewModel(sb.ToString());
            }
            return null;
        }
    }
}
