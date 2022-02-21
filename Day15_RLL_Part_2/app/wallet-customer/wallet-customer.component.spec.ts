import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WalletCustomerComponent } from './wallet-customer.component';

describe('WalletCustomerComponent', () => {
  let component: WalletCustomerComponent;
  let fixture: ComponentFixture<WalletCustomerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WalletCustomerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WalletCustomerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
