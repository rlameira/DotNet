using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Registrosativo
{
    public DateTime Data { get; set; }

    public TimeSpan Hora { get; set; }

    public double Numcartao { get; set; }

    public int Codpessoavisitada { get; set; }

    public int Codpessoavisitante { get; set; }

    public int Codequipamento { get; set; }

    public int? Codempresa { get; set; }

    public string? EntradaSaida { get; set; }

    public int? Sensor { get; set; }

    public int? Evento { get; set; }

    public int? Inoutstate { get; set; }

    public DateTime? Dataehora { get; set; }
}
