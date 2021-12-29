import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LoaderService } from './loader.service';
import {finalize}from'rxjs/operators'
@Injectable({
  providedIn: 'root'
})
export class IntercepterService implements HttpInterceptor {

  constructor( public loader:LoaderService) { }
  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    this.loader.isloading.next(true);
    return next.handle(req).pipe(
      finalize(
        () =>{
          this.loader.isloading.next(false);
        }
      )
    )
  }
}
