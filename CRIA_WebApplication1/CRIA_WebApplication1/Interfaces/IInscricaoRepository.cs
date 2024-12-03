﻿using CRIA_WebApplication1.Domains;

namespace CRIA_WebApplication1.Interfaces
{
    public interface IInscricaoRepository
    {
        List<Inscricao> ListarInscricao();

        void Cadastrar(Inscricao inscricao);
    }
}