using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Biometrium
{
    public int Codpessoa { get; set; }

    public int Iddedo { get; set; }

    public byte[]? Biometria { get; set; }

    public string? Alerta { get; set; }

    public string? Coacao { get; set; }

    public int? Algoritmo { get; set; }

    public string? Liberadoparaentrar { get; set; }

    public string? Liberadoparasair { get; set; }
}
