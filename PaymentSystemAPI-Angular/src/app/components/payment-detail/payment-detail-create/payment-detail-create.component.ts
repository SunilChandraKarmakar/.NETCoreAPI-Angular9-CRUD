import { Component, OnInit } from '@angular/core';
import { PaymentdetailService } from 'src/app/service/paymentdetail/paymentdetail.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-payment-detail-create',
  templateUrl: './payment-detail-create.component.html',
  styleUrls: ['./payment-detail-create.component.css']
})
export class PaymentDetailCreateComponent implements OnInit {

  constructor(public paymentDetailService: PaymentdetailService) { }

  ngOnInit(): void {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if(form != null)
      form.resetForm();
    
    this.paymentDetailService.formData = {
      Id: 0,
      CardOwnerName: "",
      CardNumber: "",
      ExpirationDate: null,
      CVV: "",
    }
  }
}
