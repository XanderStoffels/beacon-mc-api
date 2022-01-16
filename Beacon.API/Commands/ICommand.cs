namespace Beacon.API.Commands;

public interface ICommand
{
    /// <summary>
    /// Name with no arguments.
    /// </summary>
    public string Name { get; }
    public string Description { get; }
    public string HelpText { get; }
    public ValueTask<bool> ExecuteAsync(ICommandSender sender, string[] args, CancellationToken cToken = default);
}
