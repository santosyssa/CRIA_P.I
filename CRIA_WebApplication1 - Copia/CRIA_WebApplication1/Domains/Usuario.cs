using System;
using System.Collections.Generic;

namespace CRIA_WebApplication1.Domains;

public partial class Usuario
{
    public int IdUser { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public int? Acesso { get; set; }

    public virtual TipoUsuario? AcessoNavigation { get; set; }
}
