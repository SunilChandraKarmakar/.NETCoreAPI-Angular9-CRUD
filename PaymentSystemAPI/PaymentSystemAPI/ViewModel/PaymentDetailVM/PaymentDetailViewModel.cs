using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSystemAPI.ViewModel.PaymentDetailVM
{
    public class PaymentDetailViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Provied owner name please.")]
        [StringLength(50, MinimumLength = 20)]
        public string CardOwnerName { get; set; }

        [Required(ErrorMessage = "Provied card number please.")]
        [StringLength(16, MinimumLength = 16)]
        public string CareNumber { get; set; }

        [Required(ErrorMessage = "Select date please.")]
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }

        [Required]
        [StringLength(5, MinimumLength = 3)]
        [DataType(DataType.Password)]
        public string CVV { get; set; }
    }
}
