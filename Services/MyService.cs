public interface IMyService
{

}

public class MyService : IMyService
{
    public String GetMessage()
    {
        return "Hello from MyService!";
    }
}