using System;
using System.Threading;
using Task.Commands;
using Task.Routing;


namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            WendingMachine machine = new WendingMachine(0, new Good("Чипсы", 100, 1),

                                                                new Good("Вода", 40, 20));

            ICommandInput input = new ConsoleCommandInput(new Router(machine));

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Текущий баланс: {machine.Balance}");
                Console.WriteLine("Введите команду");
                ICommand command = input.GetCommand();
                Console.WriteLine();
                if (command is null)
                {
                    Console.WriteLine("Такой команды не существует");
                    Thread.Sleep(2000);
                    continue;
                }
                try
                {
                    command.Execute();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Что-то прошло не так" +
                       $"\nСообщение:{ex.Message}" );
                            
                    Thread.Sleep(2000);
                    continue;

                    Console.WriteLine("\nКоманда выполнена. Нажмите Enter");
                    Console.ReadKey();
                }
            }
        }
    }
}