using Microsoft.Extensions.Options;
using System;
using ConsoleDIBluprint.Models;

namespace ConsoleDIBluprint.Messaging
{
    public class ContextMessages : IContextMessages
    {
        private readonly IOptions<Settings> _settings;
        private readonly IOptions<Error> _error;

        public ContextMessages(
            IOptions<Settings> settingsOptions,
            IOptions<Error> errorOptions)
        {
            _settings = settingsOptions;
            _error = errorOptions;
        }

        public void ProgressInformation()
        {
            Console.WriteLine($"{_settings.Value.InitialMessage}");
        }

        public void UnexpectedError()
        {
            Console.WriteLine($"Error: {_error.Value.ErrorMessage}\nError Code: #{_error.Value.ErrorCode}");
        }
    }
}
