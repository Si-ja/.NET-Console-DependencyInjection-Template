using ConsoleDIBluprint.Messaging;

namespace ConsoleDIBluprint.Services
{
    public class Calculator : ICalculator
    {
        private readonly IContextMessages _contextMessages;

        public Calculator(IContextMessages contextMessagesOptions)
        {
            _contextMessages = contextMessagesOptions;
        }

        public int PutTwoIntNumbersTogether(int a, int b)
        {
            _contextMessages.ProgressInformation();
            return a + b;
        }

        public int SubtractTwoIntNumbers(int a, int b)
        {
            _contextMessages.ProgressInformation();
            return a - b;
        }
    }
}
