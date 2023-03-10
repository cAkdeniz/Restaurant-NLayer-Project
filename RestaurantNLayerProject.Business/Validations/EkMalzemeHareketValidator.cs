using FluentValidation;
using RestaurantNLayerProject.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.Business.Validations
{
    public class EkMalzemeHareketValidator : AbstractValidator<EkMalzemeHareket>
    {
        public EkMalzemeHareketValidator()
        {
            RuleFor(c => c.Fiyat).ScalePrecision(2, 10).WithMessage("Fiyat alanı belirtilen aralıkta değil.");
        }
    }
}
