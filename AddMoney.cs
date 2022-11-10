namespace Task.Commands
{
    class AddMoney : ICommand
    {
        private readonly WendingMachine _machine;
        private readonly int _moneyToAdd;

        public AddMoney(WendingMachine machine, int moneyToAdd)
        {
            _machine = machine;
            _moneyToAdd = moneyToAdd;
        }
        public void Execute() => _machine.AddBalance(_moneyToAdd);
    }

}

