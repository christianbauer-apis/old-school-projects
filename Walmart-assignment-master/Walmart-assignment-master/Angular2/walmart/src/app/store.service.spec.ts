import { TestBed, inject } from '@angular/core/testing';
import { JsonpModule, Jsonp, BaseRequestOptions, JSONPBackend } from '@angular/http';
import { MockBackend } from '@angular/http/testing';
import {StoreService} from './store.service';

describe('StoreService', () => {

  beforeEach(() => {

    TestBed.configureTestingModule({
      imports: [JsonpModule],
 providers: [
   StoreService,
   { provide: JSONPBackend, useClass: MockBackend }
 ]
    });

  });
  describe('Search()', () => {

    it('should return an Observable<Array<Video>>', inject([StoreService], (storeService) => {
      storeService.Search().subscribe((items) => {
      expect(items.length).toBe(4);
      expect(items[0].name).toEqual('Video 0');
      expect(items[1].name).toEqual('Video 1');
      expect(items[2].name).toEqual('Video 2');
      expect(items[3].name).toEqual('Video 3');
    });
  }));
  });

  describe('Lookup()', () => {

    it('should return an Observable<Array<Video>>', inject([StoreService], (storeService) => {
      storeService.Lookup().subscribe((items) => {
      expect(items.length).toBe(4);
      expect(items[0].name).toEqual('Video 0');
      expect(items[1].name).toEqual('Video 1');
      expect(items[2].name).toEqual('Video 2');
      expect(items[3].name).toEqual('Video 3');
    });
  }));
  });

  describe('Recommend()', () => {

    it('should return an Observable<Array<Video>>', inject([StoreService], (storeService) => {
      storeService.Recommend().subscribe((items) => {
      expect(items.length).toBe(4);
      expect(items[0].name).toEqual('Video 0');
      expect(items[1].name).toEqual('Video 1');
      expect(items[2].name).toEqual('Video 2');
      expect(items[3].name).toEqual('Video 3');
    });
  }));
  });
});
