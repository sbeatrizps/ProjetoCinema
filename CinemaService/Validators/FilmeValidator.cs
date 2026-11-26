using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    public class FilmeValidator : AbstractValidator<Filme>
    {
        public FilmeValidator()
        {
            RuleFor(filme => filme.Nome)
               .NotEmpty().WithMessage("Nome deve ser informado!")
               .NotNull().WithMessage("Nome deve ser informado!")
               .Length(5, 50).WithMessage("Nome deve conter entre 5 e 50 caracteres!");
            RuleFor(filme => filme.Classificacao)
               .NotEmpty().WithMessage("Classificação deve ser informada!")
               .NotNull().WithMessage("Classificação deve ser informada!")
               .Length(5, 50).WithMessage("Classificação deve conter entre 5 e 50 caracteres!");
            RuleFor(filme => filme.Genero)
              .NotNull().WithMessage("Genero deve ser informado!");
            RuleFor(filme => filme.Duracao)
              .GreaterThanOrEqualTo(1).WithMessage("Duração deve ser maior que 0!");
        }
    }
}
