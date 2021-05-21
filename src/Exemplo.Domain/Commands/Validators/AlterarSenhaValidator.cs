using FluentValidation;

namespace Exemplo.Domain.Commands.Validators
{
    public class AlterarSenhaValidator : AbstractValidator<AlterarSenhaCommand>
    {
        public AlterarSenhaValidator()
        {
            RuleFor(c => c.Senha)
                .MinimumLength(8)
                .WithMessage("Senha deve ter no mínimo 8 caracteres!");
        }
    }
}