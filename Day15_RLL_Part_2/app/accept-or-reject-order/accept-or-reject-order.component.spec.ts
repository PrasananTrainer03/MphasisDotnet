import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AcceptOrRejectOrderComponent } from './accept-or-reject-order.component';

describe('AcceptOrRejectOrderComponent', () => {
  let component: AcceptOrRejectOrderComponent;
  let fixture: ComponentFixture<AcceptOrRejectOrderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AcceptOrRejectOrderComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AcceptOrRejectOrderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
