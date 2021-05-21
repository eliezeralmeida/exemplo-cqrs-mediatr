using MediatR;

namespace Exemplo.Domain.Commands
{
    public class AlterarSenhaCommand : IRequest<Resposta>
    {
        public AlterarSenhaCommand()
        {
        }

        public AlterarSenhaCommand(string usuario, string senha) : this()
        {
            Usuario = usuario;
            Senha = senha;
        }

        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}