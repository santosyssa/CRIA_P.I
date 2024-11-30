using System;
using System.Collections.Generic;

namespace CRIA_WebApplication1.Domains;

public partial class Aluno
{
    public int IdAluno { get; set; }

    public string Nome { get; set; } = null!;

    public DateOnly? DataNascimento { get; set; }

    public string Telefone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
}
