using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using PaymentSystemAPI.Manager.Contract;
using PaymentSystemAPI.Model.Models;
using PaymentSystemAPI.ViewModel.PaymentDetailVM;

namespace PaymentSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentDetailController : ControllerBase
    {
        private readonly IMapper _iMapper;
        private readonly IPaymentDetailManager _iPaymentDetailManager;

        public PaymentDetailController(IPaymentDetailManager iPaymentDetailManager, IMapper iMapper)
        {
            _iPaymentDetailManager = iPaymentDetailManager;
            _iMapper = iMapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentDetailViewModel>> GetPaymentDetail(int? id)
        {
            if (id == null)
                return NotFound(new { errorMessage = "Selected id was not found! Try again." });

            PaymentDetailViewModel aPaymentDetailViewModelInfo = _iMapper
                .Map<PaymentDetailViewModel>(await _iPaymentDetailManager.GetById(id));

            if (aPaymentDetailViewModelInfo == null)
                return NotFound(new { errorMessage = "Selected payment detail was not found! Try again." });

            return Ok(aPaymentDetailViewModelInfo);
        }    

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentDetailViewModel>>> GetPaymentDetails()
        {
            List<PaymentDetailViewModel> getPaymentDetails = _iMapper
                .Map<List<PaymentDetailViewModel>>(await _iPaymentDetailManager.GetAll());
            return Ok(getPaymentDetails);
        }

        [HttpPost]
        public async Task<ActionResult<PaymentDetailCreateModel>> PostPaymentDetail(PaymentDetailCreateModel aPaymentDetailCreateModel)
        {
            if(ModelState.IsValid)
            {
                PaymentDetail aPaymentDetailCreateModelInfo = _iMapper.Map<PaymentDetail>(aPaymentDetailCreateModel);
                bool isSave = await _iPaymentDetailManager.Create(aPaymentDetailCreateModelInfo);
                aPaymentDetailCreateModel = _iMapper.Map<PaymentDetailCreateModel>(aPaymentDetailCreateModelInfo);

                if (isSave)
                    return Ok(aPaymentDetailCreateModel);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PaymentDetailsUpdateViewModel>> PutPaymentDetail(int? id, PaymentDetailsUpdateViewModel aPaymentDetailsUpdateViewModel)
        {
            if(ModelState.IsValid)
            {
                if (id == null || id != aPaymentDetailsUpdateViewModel.Id)
                    return NotFound(new { errorMessage = "Selected payment detail was not found! Try again" });

                PaymentDetail aPaymentDetailsUpdateVMInfo = _iMapper.Map<PaymentDetail>(aPaymentDetailsUpdateViewModel);
                bool isUpdate = await _iPaymentDetailManager.Update(aPaymentDetailsUpdateVMInfo);
                aPaymentDetailsUpdateViewModel = _iMapper.Map<PaymentDetailsUpdateViewModel>(aPaymentDetailsUpdateVMInfo);

                if (isUpdate)
                    return Ok(aPaymentDetailsUpdateViewModel);
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Remove(int? id)
        {
            if (id == null)
                return NotFound(new { errorMessage = "Selected id was not found! Try again." });

            PaymentDetail selectedPaymentDetailInfo = await _iPaymentDetailManager.GetById(id);
            if (selectedPaymentDetailInfo == null)
                return NotFound("Selected payment detail was not found! Try again.");

            bool isRemove = await _iPaymentDetailManager.Remove(selectedPaymentDetailInfo);
            
            if (isRemove)
                return Ok();

            return BadRequest(new { errorMessage = "Payment Detail was not remove! Try again." });
        }
    }
}
