namespace CICDMinimalAPIDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () =>
            {
                var greetingService = new GreetingService("World");
                return greetingService.GetGreeting();
            });

            app.Run();
        }
    }

    public class GreetingService
    {
        public string Name { get; }

        public GreetingService(string name)
        {
            Name = name;
        }
        public string GetGreeting() => $"Hello {Name}!";
    }
}
