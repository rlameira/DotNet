using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Registrosdosveiculo
{
    public DateTime Data { get; set; }

    public TimeSpan Hora { get; set; }

    public long Numcartao { get; set; }

    public int Codveiculo { get; set; }

    public int? Codunidade { get; set; }

    public int? Codequipamento { get; set; }

    public string? EntradaSaida { get; set; }

    public int? Sensor { get; set; }

    public int? Evento { get; set; }

    public int? Inoutstate { get; set; }

    public DateTime? Dataehora { get; set; }
}
