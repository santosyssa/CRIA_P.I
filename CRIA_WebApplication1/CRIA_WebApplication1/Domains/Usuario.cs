using System;
using System.Collections.Generic;

namespace CRIA_WebApplication1.Domains;

public partial class Usuario
{
    public int Ra { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<ApiFam> ApiFams { get; set; } = new List<ApiFam>();

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
}
