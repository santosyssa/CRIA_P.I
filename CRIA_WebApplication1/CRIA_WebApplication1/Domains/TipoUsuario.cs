using System;
using System.Collections.Generic;

namespace CRIA_WebApplication1.Domains;

public partial class TipoUsuario
{
   public TipoUsuario() 
    {
        Usuarios = new HashSet<Usuario>();
    }

    public int idTipoUsuario { get; set; }
    public string nome { get; set; }

    public ICollection<Usuario> Usuarios { get; set; }
}
