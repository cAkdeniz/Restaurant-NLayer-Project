using FluentValidation;
using RestaurantNLayerProject.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.Business.Validations
{
    public class AdisyonValidator: AbstractValidator<Adisyon>
    {
        public AdisyonValidator()
        {
            RuleFor(c => c.Tutar).ScalePrecision(2, 10).WithMessage("Tutar istenilen aralıkta değil.");
            RuleFor(c => c.Indirim).ScalePrecision(2, 5).WithMessage("Indirim istenilen aralıkta değil.");
        }
    }
}
