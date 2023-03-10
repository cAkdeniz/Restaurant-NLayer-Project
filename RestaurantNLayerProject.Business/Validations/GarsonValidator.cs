using FluentValidation;
using RestaurantNLayerProject.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.Business.Validations
{
    public class GarsonValidator: AbstractValidator<Garson>
    {
        public GarsonValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Adı 50 karakterden fazla olamaz.");
            RuleFor(c => c.Soyadi).MaximumLength(50).WithMessage("Soyadı 50 karakterden fazla olamaz.");
        }
    }
}
