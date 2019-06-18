using CleanDemoProject.API.Presenter;
using CleanDemoProject.API.Views;
using CleanDemoProject.Core.UseCases.Agents;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanDemoProject.API.Controllers
{
    public class AgentController
    {
        private readonly ContactAgentInteractor _interactor;
        private readonly ContactAgentResponsePresenter _presenter;

        public AgentController(ContactAgentInteractor interactor, ContactAgentResponsePresenter presenter)
        {
            _interactor = interactor;
            _presenter = presenter;
        }

        public void Contact(ContactAgentRequestMessage requestMessage)
        {
            var response = _interactor.Handle(requestMessage);

            var viewModel = _presenter.Handle(response);

            var view = new ConsoleView(viewModel);
            view.Render();
        }
    }
}
