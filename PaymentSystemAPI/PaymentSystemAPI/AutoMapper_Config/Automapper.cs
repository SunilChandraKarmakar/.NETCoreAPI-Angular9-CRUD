using AutoMapper;
using PaymentSystemAPI.Model.Models;
using PaymentSystemAPI.ViewModel.PaymentDetailVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSystemAPI.AutoMapper_Config
{
    public class Automapper : Profile 
    {
        public Automapper()
        {
            CreateMap<PaymentDetail, PaymentDetailViewModel>();
            CreateMap<PaymentDetailCreateModel, PaymentDetail>();
            CreateMap<PaymentDetail, PaymentDetailCreateModel>();
            CreateMap<PaymentDetailsUpdateViewModel, PaymentDetail>();
        }
    }
}
