using System;
using System.Collections.Generic;

namespace CRIA_WebApplication1.Domains;

public partial class Matricula
{
    public int Ra { get; set; }

    public int? Nome { get; set; }

    public int? Curso { get; set; }

    public int? Semestre { get; set; }

    public string Turno { get; set; } = null!;

    public string Campus { get; set; } = null!;

    public int? Mensalidade { get; set; }

    public virtual Curso? CursoNavigation { get; set; }

    public virtual ICollection<Inscricao> Inscricaos { get; set; } = new List<Inscricao>();

    public virtual Financeiro? MensalidadeNavigation { get; set; }

    public virtual Aluno? NomeNavigation { get; set; }
}
