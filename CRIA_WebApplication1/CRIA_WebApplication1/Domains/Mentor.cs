using System;
using System.Collections.Generic;

namespace CRIA_WebApplication1.Domains;

public partial class Mentor
{
    public int IdMentor { get; set; }

    public string? Nome { get; set; }

    public int? IdCurso { get; set; }

    public virtual ICollection<ApiFam> ApiFams { get; set; } = new List<ApiFam>();

    public virtual Curso? IdCursoNavigation { get; set; }
}
