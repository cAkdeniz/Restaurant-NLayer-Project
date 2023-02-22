﻿using FluentValidation;
using RestaurantNLayerProject.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.Business.Validations
{
    public class TanimValidator: AbstractValidator<Tanim>
    {
        public TanimValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Tanım Bilgisi 50 Karakterden Fazla Olamaz.");
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Tanım Bilgisi Boş Geçilemez.");
        }
    }
}
