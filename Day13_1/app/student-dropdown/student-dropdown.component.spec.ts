import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentDropdownComponent } from './student-dropdown.component';

describe('StudentDropdownComponent', () => {
  let component: StudentDropdownComponent;
  let fixture: ComponentFixture<StudentDropdownComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StudentDropdownComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StudentDropdownComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
