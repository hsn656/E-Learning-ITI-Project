import { Component, OnInit } from '@angular/core';
import * as AOS from 'aos';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  ngOnInit(): void {
    AOS.init();


    // fake logged in localstorage
    // put user id from db
    // localStorage.setItem("rnid", "1235de08-c663-4747-bc7b-af81e2760749")
    // localStorage.setItem("rntoken", "a token goes here")
    // localStorage.setItem("rnemail", "AhmedMustafa@gmail.com")
    // localStorage.setItem("rnroles", JSON.stringify(this.obj))
    // localStorage.setItem("rnexpireson", "Sun, 01 Aug 2021 10:29:16 GMT")
    // localStorage.setItem("rnisauthinticated", "true")

  }

}
