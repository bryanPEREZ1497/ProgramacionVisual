import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FacturaSearchComponent } from './factura-search.component';

describe('FacturaSearchComponent', () => {
  let component: FacturaSearchComponent;
  let fixture: ComponentFixture<FacturaSearchComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FacturaSearchComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FacturaSearchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
