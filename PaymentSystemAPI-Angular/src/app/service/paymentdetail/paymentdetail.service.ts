import { Injectable } from '@angular/core';
import { PaymentDetail } from 'src/app/models/paymentdetail';

@Injectable({
  providedIn: 'root'
})
export class PaymentdetailService {

  formData: PaymentDetail;

  constructor() { }
}
