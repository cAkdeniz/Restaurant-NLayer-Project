using FluentValidation;
using RestaurantNLayerProject.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.Business.Validations
{
    public class EkMalzemeValidator: AbstractValidator<EkMalzeme>
    {
        public EkMalzemeValidator()
        {
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Adı Alanı Boş Geçirilemez.");
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Adı Bilgisi 50 Karakterden Fazla Olamaz");
            RuleFor(c => c.Fiyat).ScalePrecision(2, 10).WithMessage("Fiyat Bilgisi Aralık Dışında");
        }
    }
}
