using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Horario
{
    public int Codhorario { get; set; }

    public TimeSpan? Entseg { get; set; }

    public TimeSpan? Saiseg { get; set; }

    public TimeSpan? Entter { get; set; }

    public TimeSpan? Saiter { get; set; }

    public TimeSpan? Entqua { get; set; }

    public TimeSpan? Saiqua { get; set; }

    public TimeSpan? Entqui { get; set; }

    public TimeSpan? Saiqui { get; set; }

    public TimeSpan? Entsex { get; set; }

    public TimeSpan? Saisex { get; set; }

    public TimeSpan? Entsab { get; set; }

    public TimeSpan? Saisab { get; set; }

    public TimeSpan? Entdom { get; set; }

    public TimeSpan? Saidom { get; set; }

    public TimeSpan? Entfer { get; set; }

    public TimeSpan? Saifer { get; set; }

    public string? Descrhorario { get; set; }

    public virtual ICollection<Horarioequip> Horarioequips { get; set; } = new List<Horarioequip>();
}
