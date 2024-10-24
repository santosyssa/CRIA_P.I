using System;
using System.Collections.Generic;

namespace CRIA_WebApplication1.Domains;

public partial class Curso
{
    public int IdCurso { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<ApiFam> ApiFams { get; set; } = new List<ApiFam>();

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();

    public virtual ICollection<Mentor> Mentors { get; set; } = new List<Mentor>();
}
