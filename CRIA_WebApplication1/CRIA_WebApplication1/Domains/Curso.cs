using System;
using System.Collections.Generic;

namespace CRIA_WebApplication1.Domains;

public partial class Curso
{
    public int IdCurso { get; set; }

    public string Nome { get; set; } = null!;

    public string Habilitacao { get; set; } = null!;

    public int Duracao { get; set; }

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
}
