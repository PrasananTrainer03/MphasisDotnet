import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployDropdownComponent } from './employ-dropdown.component';

describe('EmployDropdownComponent', () => {
  let component: EmployDropdownComponent;
  let fixture: ComponentFixture<EmployDropdownComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmployDropdownComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmployDropdownComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
