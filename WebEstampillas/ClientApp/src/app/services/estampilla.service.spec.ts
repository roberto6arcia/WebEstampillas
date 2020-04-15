import { TestBed } from '@angular/core/testing';

import { EstampillaService } from './estampilla.service';

describe('EstampillaService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: EstampillaService = TestBed.get(EstampillaService);
    expect(service).toBeTruthy();
  });
});
