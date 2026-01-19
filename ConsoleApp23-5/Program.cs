using System;
using System.Collections.Generic;
public interface IOutput
{
    void Write(string text);
}

public class ConsoleOutput : IOutput
{
    public void Write(string text)
    {
        Console.WriteLine(text);
    }
}

public class FileOutput : IOutput
{
    private readonly string filePath;

    public FileOutput(string filePath)
    {
        this.filePath = filePath;
    }

    public void Write(string text)
    {
        File.AppendAllText(filePath, text + Environment.NewLine);
    }
}

public class ReportPrinter
{
    private readonly IOutput output;

    public ReportPrinter(IOutput output)
    {
        this.output = output;
    }

    public void Print(string text)
    {
        output.Write(text);
    }
}
