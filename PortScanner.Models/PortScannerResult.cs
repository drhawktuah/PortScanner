using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortScanner.PortScanner.Models;

public record PortScannerResult(string Target, int StartPort, int EndPort, IReadOnlyList<int> OpenPorts, DateTime ScannedAt)
{

}