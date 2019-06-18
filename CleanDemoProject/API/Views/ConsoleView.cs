using CleanDemoProject.API.Models;
using System;

namespace CleanDemoProject.API.Views
{
    public class ConsoleView
    {
        private readonly ContactAgentResponseViewModel _viewModel;

        public ConsoleView(ContactAgentResponseViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Render()
        {
            Console.WriteLine(_viewModel.Text);
            Console.WriteLine("press any key to exit");
            Console.ReadLine();
        }
    }
}
