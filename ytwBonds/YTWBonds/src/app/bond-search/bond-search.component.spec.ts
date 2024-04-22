import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BondSearchComponent } from './bond-search.component';

describe('BondSearchComponent', () => {
  let component: BondSearchComponent;
  let fixture: ComponentFixture<BondSearchComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [BondSearchComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(BondSearchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
