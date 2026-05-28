namespace SurpassDataPopulator.Console.Display.Mappers;

/// <summary>
/// Interface for creating display results to console output using Spectre.Console
/// </summary>
/// <typeparam name="TResult">The type of display result to the console</typeparam>
public interface IConsoleAppResultOutput<in TResult>
{
    /// <summary>
    /// Prints the result to the console
    /// </summary>
    /// <param name="result">The result to print</param>
    void Print(TResult result);
}