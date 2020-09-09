using PaymentSystemAPI.Manager.Base;
using PaymentSystemAPI.Manager.Contract;
using PaymentSystemAPI.Model.Models;
using PaymentSystemAPI.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentSystemAPI.Manager
{
    public class PaymentDetailManager : BaseManager<PaymentDetail>, IPaymentDetailManager
    {
        private readonly IPaymentDetailRepository _iPaymentDetailRepository;

        public PaymentDetailManager(IPaymentDetailRepository iPaymentDetailRepository) 
            : base(iPaymentDetailRepository)
        {
            _iPaymentDetailRepository = iPaymentDetailRepository;
        }
    }
}
