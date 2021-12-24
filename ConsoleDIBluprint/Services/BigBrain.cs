using ConsoleDIBluprint.Models;
using ConsoleDIBluprint.Messaging;
using Microsoft.Extensions.Options;
using System;

namespace ConsoleDIBluprint.Services
{
    public class BigBrain : IBigBrain
    {
        private readonly ICalculator Calculator;
        private readonly IContextMessages _contextMessages;

        public BigBrain(
            ICalculator calculator,
            IContextMessages _contextMessagesOptions)
        {
            Calculator = calculator;
            _contextMessages = _contextMessagesOptions;
        }

        public bool InteractWithNumbers(int a, int b, string action)
        {
            int answer;
            switch (action)
            {
                case "add":
                    answer = Calculator.PutTwoIntNumbersTogether(a, b);
                    Console.WriteLine($"Numbers are put together. The answer is: {answer}");
                    return true;

                case "subtract":
                    answer = Calculator.SubtractTwoIntNumbers(a, b);
                    Console.WriteLine($"Numbers are subtracted. The answer is: {answer}");
                    return true;

                default:
                    Console.WriteLine("No appropriate action was told. Chose between 'add' and 'subtract'");
                    _contextMessages.UnexpectedError();
                    return false;
            }
        }
    }
}
