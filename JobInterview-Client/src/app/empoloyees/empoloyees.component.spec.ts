import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmpoloyeesComponent } from './empoloyees.component';

describe('EmpoloyeesComponent', () => {
  let component: EmpoloyeesComponent;
  let fixture: ComponentFixture<EmpoloyeesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmpoloyeesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmpoloyeesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
