import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PaymentDetailComponent } from './components/payment-detail/payment-detail.component';
import { PaymentDetailListComponent } from './components/payment-detail/payment-detail-list/payment-detail-list.component';
import { PaymentDetailCreateComponent } from './components/payment-detail/payment-detail-create/payment-detail-create.component';

import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    PaymentDetailComponent,
    PaymentDetailListComponent,
    PaymentDetailCreateComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [PaymentDetailComponent]
})
export class AppModule { }
