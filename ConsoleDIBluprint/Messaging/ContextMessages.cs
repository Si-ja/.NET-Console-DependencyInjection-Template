using Microsoft.Extensions.Options;
using System;
using ConsoleDIBluprint.Models;

namespace ConsoleDIBluprint.Messaging
{
    public class ContextMessages : IContextMessages
    {
        private readonly Settings _settings;
        private readonly Error _error;

        public ContextMessages(
            IOptions<Settings> settingsOptions,
            IOptions<Error> errorOptions)
        {
            _settings = settingsOptions.Value;
            _error = errorOptions.Value;
        }

        public void ProgressInformation()
        {
            Console.WriteLine($"{_settings.InitialMessage}");
        }

        public void UnexpectedError()
        {
            Console.WriteLine($"Error: {_error.ErrorMessage}\nError Code: #{_error.ErrorCode}");
        }
    }
}
