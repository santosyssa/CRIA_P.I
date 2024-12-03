using System;
using System.Collections.Generic;

namespace CRIA_WebApplication1.Domains;

public partial class Financeiro
{
    public int IdFin { get; set; }

    public DateOnly DataVenc { get; set; }

    public bool? AVencer { get; set; }

    public bool? Pago { get; set; }

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
}
