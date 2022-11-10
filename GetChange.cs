namespace Task.Commands
{
    class GetChange : ICommand
    {
        private readonly WendingMachine _machine;

        public GetChange(WendingMachine machine) => _machine = machine;

        public void Execute() => _machine.DiscardBalance(_machine.Balance);
    }
}

