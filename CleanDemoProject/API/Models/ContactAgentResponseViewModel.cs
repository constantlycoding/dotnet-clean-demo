﻿namespace CleanDemoProject.API.Models
{
    public class ContactAgentResponseViewModel
    {
        public string Text { get; private set; }

        public ContactAgentResponseViewModel(string text)
        {
            Text = text;
        }
    }
}
