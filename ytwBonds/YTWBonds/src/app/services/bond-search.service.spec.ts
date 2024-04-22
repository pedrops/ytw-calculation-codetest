import { TestBed } from '@angular/core/testing';

import { BondSearchService } from './bond-search.service';

describe('BondSearchService', () => {
  let service: BondSearchService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BondSearchService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
