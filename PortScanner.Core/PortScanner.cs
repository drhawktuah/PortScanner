using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortScanner.PortScanner.Core;

public sealed class PortScanner
{
    public string Target { get; }

    public int StartPort { get; }
    public int EndPort { get; }
    public int Timeout { get; }
    public int Threads { get; }

    public IEnumerable<int> Ports => Enumerable.Range(StartPort, EndPort);

    public PortScanner(string target, int start, int end, int timeout, int threads)
    {
        Target = target;
        StartPort = start;
        EndPort = end;

        Timeout = timeout;
        Threads = threads;
    }
}