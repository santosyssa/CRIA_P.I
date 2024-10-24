using System;
using System.Collections.Generic;

namespace CRIA_WebApplication1.Domains;

public partial class ApiFam
{
    public int IdApi { get; set; }

    public int? Ra { get; set; }

    public int? IdMentor { get; set; }

    public int? IdCurso { get; set; }

    public int? ValidarMatricula { get; set; }

    public virtual Curso? IdCursoNavigation { get; set; }

    public virtual Mentor? IdMentorNavigation { get; set; }

    public virtual Usuario? RaNavigation { get; set; }

    public virtual Matricula? ValidarMatriculaNavigation { get; set; }
}
