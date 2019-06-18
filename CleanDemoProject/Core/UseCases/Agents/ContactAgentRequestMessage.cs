using MediatR;

namespace CleanDemoProject.Core.UseCases.Agents
{
    public class ContactAgentRequestMessage : IRequest<ContactAgentResponseMessage>
    {
        public string CustomerEmailAddress { get; set; }
        public long CustomerPhoneNumber { get; set; }
        public int HouseId { get; set; } //the house in which the customer is potentially interested
    }

}
