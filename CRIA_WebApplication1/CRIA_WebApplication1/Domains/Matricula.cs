using System;
using System.Collections.Generic;

namespace CRIA_WebApplication1.Domains;

public partial class Matricula
{
    public int IdMatri { get; set; }

    public int? Ra { get; set; }

    public int? IdCurso { get; set; }

    public DateOnly? Mensaliade { get; set; }

    public bool? Validacao { get; set; }

    public virtual ICollection<ApiFam> ApiFams { get; set; } = new List<ApiFam>();

    public virtual Curso? IdCursoNavigation { get; set; }

    public virtual Usuario? RaNavigation { get; set; }
}
