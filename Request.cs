

namespace Task
{
   class Request
    {
    public string Command { get; }
    public int[] Parameters { get; }

    public Request(string command, int[] parameters)
        {
            Command = command;
            Parameters = parameters;
        }
        public bool IsIncorrectParametersCount(int correctCount ) => correctCount != Parameters.Length;
    }
}
