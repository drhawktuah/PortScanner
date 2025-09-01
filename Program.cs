using System.CommandLine;
using PortScanner.PortScanner.Core;

namespace PortScanner;

public class Program
{
    public static readonly RootCommand rootCommand = [];

    public static void Main(string[] args)
    {
        rootCommand.AddOption(PortScannerArguments.)
    }

    public static void SetHandler()
    {
        return rootCommand.SetHandler(async (string target, int start, int end, int timeout, int threads, bool json, bool banner) =>
        {
            var(host, inferredPort) = 
        });
    }

    public static void AddCommands()
    {
        rootCommand.AddOption(PortScannerArguments.TargetOption);
        rootCommand.AddOption(PortScannerArguments.StartPortOption);
        rootCommand.AddOption(PortScannerArguments.EndPortOption);
        rootCommand.AddOption(PortScannerArguments.TimeoutOption);
        rootCommand.AddOption(PortScannerArguments.ThreadsOption);
        rootCommand.AddOption(PortScannerArguments.JSONOutputOption);
        rootCommand.AddOption(PortScannerArguments.BannerOption);
    }
}