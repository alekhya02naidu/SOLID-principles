using System;
using SolidPrinciples.SRP;

public class Program
{
    public static void Main(string[] args)
    {
        Logger logger = new Logger();
        logger.LogInfo("Logger Information");
        logger.LogError("Log error message");
        logger.LogSuccess("Log Success message");
    }
}