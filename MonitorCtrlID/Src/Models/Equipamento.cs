using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Equipamento
{
    public int Codequipamento { get; set; }

    public int Codportaria { get; set; }

    public int Codmodelo { get; set; }

    public string? Equipamento1 { get; set; }

    public string? Ip { get; set; }

    public int? Porta { get; set; }

    public string? Obs { get; set; }

    public string? Numserie { get; set; }

    public int? Numdispositivo { get; set; }

    public string? EntrSaida { get; set; }

    public string? Layout { get; set; }

    public string? Habilitado { get; set; }

    public string? Enviadigitais { get; set; }

    public string? Cancela { get; set; }

    public string? Barreira { get; set; }

    public string? Engolidor { get; set; }

    public string? Liberamanual { get; set; }

    public string? Capturadigital { get; set; }

    public string? Thread { get; set; }

    public string? Dependenteacompanhado { get; set; }

    public string? Academia { get; set; }

    public virtual Modeloequipamento CodmodeloNavigation { get; set; } = null!;

    public virtual Portarium CodportariaNavigation { get; set; } = null!;

    public virtual ICollection<Horarioequip> Horarioequips { get; set; } = new List<Horarioequip>();
}
