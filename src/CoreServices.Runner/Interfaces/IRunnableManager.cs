namespace CoreServices.Runner.Interfaces;

public interface IRunnableManager
{
    IEnumerable<IRunnable?> GetRunnableInstances(string namespacePrefix);

    void RunRunnable(IRunnable runnable);

    public void RunAllRunnables(string namespacePrefix);
}