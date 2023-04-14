using FluentValidation;
using movie.Dto;

namespace movie.Validator
{
    public class MovieDtoValidator : AbstractValidator<MovieDto>
    { 
        public MovieDtoValidator() 
        { 
            RuleFor(movie => movie.Title).NotEmpty().WithMessage("It's invalid").NotNull().WithMessage("It's invalid");
            RuleFor(movie => movie.Gender).NotEmpty().WithMessage("It's invalid").NotNull().WithMessage("It's invalid");
        }
    }
}
