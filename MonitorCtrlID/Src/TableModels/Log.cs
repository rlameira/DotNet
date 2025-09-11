using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Log
{
    public int Codusuario { get; set; }

    public int Codtipolog { get; set; }

    public DateTime Data { get; set; }

    public TimeSpan Hora { get; set; }

    public int Codvisitante { get; set; }
}
