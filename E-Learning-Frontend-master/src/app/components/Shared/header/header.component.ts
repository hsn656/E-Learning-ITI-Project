import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { ThemePalette } from '@angular/material/core';
import { Router, NavigationStart , NavigationEnd, NavigationCancel, NavigationError,Event  } from '@angular/router';
import { LoaderService } from '../../loader/loader.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
  imageUrl:string
  color: ThemePalette = 'warn';
 ShowLoadIndcate:boolean = true;
 userEmail:string = localStorage.getItem("rnemail")
  constructor(public loader:LoaderService,private router:Router ){
   }

  ngOnInit(): void {
    setInterval(()=>{
      this.userEmail=localStorage.getItem("rnemail")
      this.imageUrl=localStorage.getItem("rnimage")
    },500)
  }

  getImg(): string{
    return this.imageUrl==null ? "assets/images/person-icon.png" : "https://elearningbackendapi.azurewebsites.net/"+this.imageUrl
  }


  logOut(){
    localStorage.removeItem("rnid")
    localStorage.removeItem("rntoken")
    localStorage.removeItem("rnemail")
    localStorage.removeItem("rnroles")
    localStorage.removeItem("rnid")
    this.userEmail=""
    this.router.navigateByUrl('/login')
  }
  goHome(){
    this.router.navigateByUrl('/Home')
  }


}
