using System.Diagnostics;

namespace DllInjector.Services.Interfaces;

public interface IMakeProcess
{
    /// <summary>
    /// Находит в системе все процессы.
    /// </summary>
    /// <returns>Вернет список найденых процессов.</returns>
    Process[] GetAllProcesses();
}