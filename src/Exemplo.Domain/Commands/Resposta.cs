using System.Collections.Generic;

namespace Exemplo.Domain.Commands
{
    public class Resposta
    {
        public Resposta(IList<string> erros)
        {
            Sucesso = false;
            Erros = erros;
        }

        public Resposta(bool sucesso)
        {
            Sucesso = sucesso;
        }

        public bool Sucesso { get; }
        public IList<string> Erros { get; }
    }
}