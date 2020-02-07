import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OnlinecustomerComponent } from './onlinecustomer.component';

describe('OnlinecustomerComponent', () => {
  let component: OnlinecustomerComponent;
  let fixture: ComponentFixture<OnlinecustomerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OnlinecustomerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OnlinecustomerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
