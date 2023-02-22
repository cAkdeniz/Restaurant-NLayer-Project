using FluentValidation;
using RestaurantNLayerProject.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.Business.Validations
{
    public class UrunHareketValidator : AbstractValidator<UrunHareket>
    {
        public UrunHareketValidator()
        {
            RuleFor(c => c.Indirim).ScalePrecision(2, 5).WithMessage("Indirim istenilen aralıkta değil.");
            RuleFor(c => c.Miktar).ScalePrecision(3, 8).WithMessage("Miktar istenilen aralıkta değil.");
        }
    }
}
