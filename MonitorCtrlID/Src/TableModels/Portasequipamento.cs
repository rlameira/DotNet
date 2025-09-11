using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Portasequipamento
{
    public int Codequipamento { get; set; }

    public int Codporta { get; set; }

    public int Codsensor { get; set; }

    public string? Baixadocadastro { get; set; }

    public int Inout { get; set; }

    public string? Entradasaida { get; set; }

    public string? Antena { get; set; }
}
