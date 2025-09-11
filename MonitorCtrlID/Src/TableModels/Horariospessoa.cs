using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Horariospessoa
{
    public int Codhorario { get; set; }

    public int Codpessoa { get; set; }

    public int Codporta { get; set; }

    public int Sensor { get; set; }

    public DateTime? Dtgravado { get; set; }

    public DateTime? Dtvinculado { get; set; }
}
