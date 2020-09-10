import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PaymentDetailCreateComponent } from './payment-detail-create.component';

describe('PaymentDetailCreateComponent', () => {
  let component: PaymentDetailCreateComponent;
  let fixture: ComponentFixture<PaymentDetailCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PaymentDetailCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PaymentDetailCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
