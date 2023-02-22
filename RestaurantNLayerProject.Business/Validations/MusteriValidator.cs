using FluentValidation;
using RestaurantNLayerProject.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.Business.Validations
{
    public class MusteriValidator: AbstractValidator<Musteri>
    {
        public MusteriValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Adı bilgisi 50 karakterden fazla olamaz.");
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Adı bilgisi boş geçilemez.");
            RuleFor(c => c.Soyadi).MaximumLength(50).WithMessage("Soyadı bilgisi 50 karakterden fazla olamaz.");
            RuleFor(c => c.KartNo).MaximumLength(20).WithMessage("KartNo bilgisi 50 karakterden fazla olamaz.");
        }
    }
}
