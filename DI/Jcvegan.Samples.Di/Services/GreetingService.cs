namespace Jcvegan.Samples.Di.Services
{
public class GreetingService : IGreetingService
{
    public string SayHello(string name)
    {
        return $"Hello {name}!";
    }
}
}