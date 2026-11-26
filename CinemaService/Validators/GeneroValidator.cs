using FluentValidation;
using CinemaDomain;

namespace CinemaService.Validators
{
    public class GeneroValidator : AbstractValidator<Genero>
    {
        public GeneroValidator()
        {
            RuleFor(genero => genero.Nome)
                .NotEmpty().WithMessage("Gênero deve ser informado!")
                .NotNull().WithMessage("Gênero deve ser informado!")
                .Length(5, 50).WithMessage("Gênero deve conter entre 5 e 50 caracteres");
        }
    }
}
