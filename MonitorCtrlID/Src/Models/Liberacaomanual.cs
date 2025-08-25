using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Liberacaomanual
{
    public int Codliberacao { get; set; }

    public int? Codpessoa { get; set; }

    public int? Codusuario { get; set; }

    public string? Entradasaida { get; set; }

    public DateTime? Dtliberacao { get; set; }

    public int? Codequipamento { get; set; }

    public int? Sensor { get; set; }

    public string? Motivo { get; set; }
}
