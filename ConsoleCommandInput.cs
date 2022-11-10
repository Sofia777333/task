using System;
using Task.Routing;

namespace Task.Commands
{


    class ConsoleCommandInput : ICommandInput
    {
        private readonly Router _router;

        public ConsoleCommandInput(Router router) => _router = router;

        public ICommand GetCommand()
        {

            string commandToParse = Console.ReadLine();

            Request request = Parse(commandToParse);

            return _router.CreateCommand(request);
        }
        private Request Parse(string input)
        {
            string[] terms = input.Trim().Split();
            int[] parameters = new int[0];

            if (terms.Length > 1)
            {
                parameters = new int[terms.Length - 1];
                for (int i = 1; i < terms.Length; i++)
                    parameters[i - 1] = Convert.ToInt32(terms[i]);
            }
            return new Request(terms[0], parameters);
        }
    } 
}

