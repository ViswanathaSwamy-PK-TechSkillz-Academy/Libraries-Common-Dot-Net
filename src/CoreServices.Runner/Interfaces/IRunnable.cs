namespace CoreServices.Runner.Interfaces;

public interface IRunnable
{
    string Title { get; }

    void Run();
}
