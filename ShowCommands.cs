using System;

namespace Task.Commands
{
    class ShowCommands : ICommand
    {
        private readonly string[] _commands;

     public ShowCommands(params string[] commands) => _commands = commands;
         public void Execute()
        {
            for (int i = 0; i < _commands.Length; i++)
            {
                string command = _commands[i];
                Console.WriteLine($"{i+1}.|{command}");
            }
        }
    }
}
