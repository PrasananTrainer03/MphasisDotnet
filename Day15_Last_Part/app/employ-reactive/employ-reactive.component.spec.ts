import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployReactiveComponent } from './employ-reactive.component';

describe('EmployReactiveComponent', () => {
  let component: EmployReactiveComponent;
  let fixture: ComponentFixture<EmployReactiveComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmployReactiveComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmployReactiveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
