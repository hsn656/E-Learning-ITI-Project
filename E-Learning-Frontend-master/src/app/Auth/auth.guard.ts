import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  /**
   *
   */
  constructor(private router:Router) {


  }
  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
      if(!localStorage.getItem('rntoken')){
        if(confirm("يجب عليك تسجيل الدخول أولا؟").valueOf())
          this.router.navigateByUrl('/login')
        return false
      }else if(!localStorage.getItem("rnroles").includes('Gold')){
        alert("لست مشتركا حتى  الآن قم بالتواصل مع الرقم التالي واتساب للاشتراك والاستمتاع بكل الخدمات 01552120657")
        return false
      }else
      return true




  }

}
