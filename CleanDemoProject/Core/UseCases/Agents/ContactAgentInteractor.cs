using CleanDemoProject.Core.Entities;
using FluentValidation;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanDemoProject.Core.UseCases.Agents
{
    public class ContactAgentInteractor : IRequestHandler<ContactAgentRequestMessage, ContactAgentResponseMessage>
    {
        private readonly IRepository<int, House> _repository;
        private readonly IValidator<ContactAgentRequestMessage> _validator;

        public ContactAgentInteractor(IValidator<ContactAgentRequestMessage> validator, IRepository<int, House> repository)
        {
            _validator = validator;
            _repository = repository;
        }

        public ContactAgentResponseMessage Handle(ContactAgentRequestMessage request)
        {
            var validationResult = _validator.Validate(request);
            if (validationResult.IsValid == false)
                return new ContactAgentResponseMessage(validationResult);

            var house = _repository.Get(request.HouseId);
            house.RegisterInterest(new Interest
            {
                CustomerEmailAddress = request.CustomerEmailAddress,
                CustomerPhoneNumber = request.CustomerPhoneNumber,
                CreationDate = DateTime.Now
            });

            _repository.Save(house);

            return new ContactAgentResponseMessage(validationResult, request.HouseId);
        }

        public Task<ContactAgentResponseMessage> Handle(ContactAgentRequestMessage request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
