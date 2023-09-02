import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RezervareComponent } from './rezervare.component';

describe('RezervareComponent', () => {
  let component: RezervareComponent;
  let fixture: ComponentFixture<RezervareComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [RezervareComponent]
    });
    fixture = TestBed.createComponent(RezervareComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
