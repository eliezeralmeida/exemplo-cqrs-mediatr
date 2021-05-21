using System.Threading;
using System.Threading.Tasks;
using Exemplo.Domain.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Exemplo.WebApi.Controllers
{
    [ApiController]
    [Route("usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsuarioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("alterar-senha")]
        public async Task<IActionResult> AlterarSenha(AlterarSenhaCommand mensagem)
        {
            var res = await _mediator.Send(mensagem, CancellationToken.None);
            if (!res.Sucesso) return BadRequest(res.Erros);

            return Ok();
        }
    }
}