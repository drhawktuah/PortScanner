using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Threading.Tasks;

namespace PortScanner.PortScanner.Core;

public static class PortScannerArguments
{
    public static readonly Option<string> TargetOption = new("--target", "Target IP or hostname")
    {
        ArgumentHelpName = "target",
        IsRequired = true
    };

    public static readonly Option<int> StartPortOption = new("--start-port", () => 1, "Start of the port range")
    {
        ArgumentHelpName = "startport"
    };

    public static readonly Option<string> EndPortOption = new("--end-port", "End of the port range")
    {
        ArgumentHelpName = "endport",
    };

    public static readonly Option<int> TimeoutOption = new("--timeout", () => 1000, "Timeout in milliseconds for each port scan")
    {
        ArgumentHelpName = "timeout"
    };

    public static readonly Option<int> ThreadsOption = new("--threads", () => 10, "Number of concurrent threads for scanning")
    {
        ArgumentHelpName = "threads"
    };

    public static readonly Option<bool> JSONOutputOption = new("--json", "Output results in JSON format")
    {
        ArgumentHelpName = "json",
    };

    public static readonly Option<bool> BannerOption = new("--banner", "Enable HTTP banner grabbing")
    {
        ArgumentHelpName = "banner",
    };
}