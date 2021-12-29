import { TestBed } from '@angular/core/testing';

import { IntercepterService } from './intercepter.service';

describe('IntercepterService', () => {
  let service: IntercepterService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(IntercepterService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
