using CleanDemoProject.API.Controllers;
using CleanDemoProject.API.Presenter;
using CleanDemoProject.Core.Entities;
using CleanDemoProject.Core.UseCases.Agents;
using CleanDemoProject.Infrastructure.Gateways;
using System;

namespace CleanDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var dummy = new InMemoryHouseRepository();
            dummy.Save(new House { Id = 45474845, Address = "Dam 1, Amsterdam", Leads = { } });

            var controller =
                new AgentController(
                    new ContactAgentInteractor(
                        new ContactAgentRequestMessageValidator(),
                        dummy),
                    new ContactAgentResponsePresenter());

            controller.Contact(
                new ContactAgentRequestMessage
                {
                    CustomerEmailAddress = "stephan@funda.nl",
                    CustomerPhoneNumber = 555123456,
                    HouseId = 45474845
                }
            );
        }
    }
}
