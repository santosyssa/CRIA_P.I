using System;
using System.Collections.Generic;

namespace CRIA_WebApplication1.Domains;

public partial class Inscricao
{
    public int Ra { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateOnly? Ano { get; set; }

    public int? Fam { get; set; }

    public virtual Matricula? FamNavigation { get; set; }
}
