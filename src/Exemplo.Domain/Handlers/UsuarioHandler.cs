using System.Threading;
using System.Threading.Tasks;
using Exemplo.Domain.Commands;
using Exemplo.Domain.Entities;
using MediatR;

namespace Exemplo.Domain.Handlers
{
    public class UsuarioHandler : IRequestHandler<AlterarSenhaCommand, Resposta>
    {
        public async Task<Resposta> Handle(AlterarSenhaCommand request, CancellationToken cancellationToken)
        {
            // Simulação de alteração de senha
            var usuario = new Usuario("eliezer@example.com", "12345678");

            usuario.DefinirSenha(request.Senha);

            return await Task.FromResult(new Resposta(true));
        }
    }
}