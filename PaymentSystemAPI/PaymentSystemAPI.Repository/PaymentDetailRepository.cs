using PaymentSystemAPI.Model.Models;
using PaymentSystemAPI.Repository.Base;
using PaymentSystemAPI.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentSystemAPI.Repository
{
    public class PaymentDetailRepository : BaseRepository<PaymentDetail>, IPaymentDetailRepository
    {
    }
}
