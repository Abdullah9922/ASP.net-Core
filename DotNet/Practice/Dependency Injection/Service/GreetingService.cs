namespace Dependency_Injection.Service
{
    public class GreetingService : IGreeting
    {
        public string GetGreeting()
        {
            return "Hi.... I am from DI.";
        }
    }
}
