using System;
using System.Threading;
using System.Threading.Tasks;
using Exemplo.Domain.Commands;
using Exemplo.Domain.Handlers;
using Xunit;

namespace Exemplo.Domain.Tests
{
    public class UsuarioHandlerTests
    {
        private readonly UsuarioHandler _handler;

        public UsuarioHandlerTests()
        {
            _handler = new UsuarioHandler();
        }

        [Fact(DisplayName = "Alterar senha de usuário com tamanho inválido")]
        public async Task AlterarSenha_TamanhoInvalido_DeveRejeitar()
        {
            // Esse é um teste para simular a necessidade de incluir o validador do flunet
            // que está no pipeline do MediatR no Teste de Unidade do Hanlder

            // Essa validação será testada nos testes de integração, porém estou procurando 
            // uma maneira de inclui-las no Teste de Unidade do Handler

            // Estou buscando alternativas para no ACT eu conseguir testar meu validator que está
            // sendo utilizado pelo pipline

            // PS: Por esse testes acabei percebendo que a responsabilidade de testar está sendo 
            // do MediatR, logo não terei essa validação atrelado ao método do handler.

            // Arrange
            var command = new AlterarSenhaCommand("eliezer@example.com", "SW3t1u#");

            // Act
            var resposta = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.False(resposta.Sucesso);
            Assert.Single(resposta.Erros);
        }
    }
}
