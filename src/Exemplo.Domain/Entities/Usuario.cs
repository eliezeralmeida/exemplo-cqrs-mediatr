using System;

namespace Exemplo.Domain.Entities
{
    public class Usuario
    {
        public Usuario(string usuario, string senha)
        {
            NomeUsuario = usuario;
            DefinirSenha(senha);
        }

        public string NomeUsuario { get; private set; }
        public string Senha { get; private set; }

        public void DefinirSenha(string novaSenha)
        {
            if (novaSenha.Length <= 8) throw new InvalidOperationException("Nova Senha não pode ser menor que 8");

            Senha = novaSenha;
        }
    }
}