using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace ValidacijaII.Shared
{
	public class ValidatorZaOsobu : AbstractValidator<Osoba>
	{
		public ValidatorZaOsobu()
		{
			RuleFor(o => o.Ime).NotEmpty().WithMessage("Ne sme prazno!")
								.MinimumLength(3).WithMessage("Prekratko!")
								.MaximumLength(10).WithMessage("Predugo!");
			RuleFor(o => o.Prezime).NotEmpty().WithMessage("Nista prazno!");
		}
	}

	public class Osoba
	{
		public string Ime { get; set; }
		public string Prezime { get; set; }
	}
}
