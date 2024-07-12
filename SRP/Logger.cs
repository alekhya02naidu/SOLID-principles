using System;

namespace SolidPrinciples.SRP;

// SOLID principles - S : SRP
// Single Responsibility Principle
// A class should have only one responsibility or purpose

public class Logger 
{
    public void LogInfo(string message)
    {
        Console.WriteLine(message);
    }
    
    public void LogError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
    }
    public void LogSuccess(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
    }
}