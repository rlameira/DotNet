using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Idequipamento
{
    public long Id { get; set; }

    public int Codequipamento { get; set; }

    public int Sensor { get; set; }

    public int Codhorario { get; set; }
}
