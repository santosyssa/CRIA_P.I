using System;
using System.Collections.Generic;

namespace CRIA_WebApplication1.Domains;

public partial class TipoUsuario
{
    public int IdTipoUsuario { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
