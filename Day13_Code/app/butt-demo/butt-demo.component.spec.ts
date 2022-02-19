import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ButtDemoComponent } from './butt-demo.component';

describe('ButtDemoComponent', () => {
  let component: ButtDemoComponent;
  let fixture: ComponentFixture<ButtDemoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ButtDemoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ButtDemoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
