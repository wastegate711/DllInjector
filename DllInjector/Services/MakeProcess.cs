using System.Diagnostics;
using DllInjector.Services.Interfaces;

namespace DllInjector.Services;

/// <summary>
/// Получает информацию и управляет процессами.
/// </summary>
public class MakeProcess : IMakeProcess
{
    /// <inheritdoc />
    public Process[] GetAllProcesses()
    {
        return Process.GetProcesses();
    }
}