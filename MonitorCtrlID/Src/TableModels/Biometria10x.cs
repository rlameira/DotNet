using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Biometria10x
{
    public int Iddedo { get; set; }

    public byte[]? Biometria { get; set; }

    public int Codpessoa { get; set; }

    public string? Alerta { get; set; }

    public string? Coacao { get; set; }

    public virtual Pessoa CodpessoaNavigation { get; set; } = null!;
}
