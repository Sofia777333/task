using Task.Routing;

namespace Task.Commands
{
    class Logout : ICommand
    {
        private readonly Router _router;
        public Logout(Router router) => _router = router;
        public void Execute() => _router.Logout();
    }

}
