using CoreServices.Runner.Interfaces;
using HeaderFooter.Interfaces;
using Microsoft.Extensions.Logging;
using System.Reflection;
namespace CoreServices.Runner;

public class RunnableManager(ILogger<RunnableManager> logger, IHeader header, IFooter footer) : IRunnableManager
{
    private readonly ILogger<RunnableManager> _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    private readonly IFooter _footer = footer ?? throw new ArgumentNullException(nameof(footer));
    private readonly IHeader _header = header ?? throw new ArgumentNullException(nameof(header));

    public IEnumerable<IRunnable?> GetRunnableInstances(string namespacePrefix)
    {
        Type runnableInterfaceType = typeof(IRunnable);
        Assembly? assembly = Assembly.GetEntryAssembly();

        _logger.LogWarning($"{runnableInterfaceType} == {assembly?.FullName}");

        if (runnableInterfaceType == null || assembly == null)
        {
            _logger.LogError("Unable to retrieve types due to null reflection objects.");

            return Enumerable.Empty<IRunnable?>();
        }

        List<IRunnable?> runnableInstances = assembly.GetTypes()
            .Where(type => type.IsClass && type.Namespace == namespacePrefix && runnableInterfaceType.IsAssignableFrom(type))
            .Select(type => (IRunnable?)Activator.CreateInstance(type))
            .ToList();

        if (!runnableInstances.Any())
        {
            _logger.LogWarning($"No runnables found in namespace '{namespacePrefix}'.");
        }

        return runnableInstances;
    }

    public void RunRunnable(IRunnable runnable)
    {
        try
        {
            _header.DisplayHeader('=', runnable.Title);

            runnable.Run();

            _footer.DisplayFooter('-');
        }
        catch (Exception ex)
        {
            _logger.LogError($"An error occurred while running {runnable.GetType().Name}: {ex.Message}");
        }
    }

    public void RunAllRunnables(string namespacePrefix)
    {
        // Discover and instantiate IRunnable instances in the Runnables namespace
        IEnumerable<IRunnable?>? runnableInstances = GetRunnableInstances(namespacePrefix);

        foreach (IRunnable? runnable in runnableInstances!)
        {
            RunRunnable(runnable!);

            _footer.DisplayFooter('*', 140, ConsoleColor.DarkMagenta);
        }
    }
}