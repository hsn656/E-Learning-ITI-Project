import { Component, OnInit } from '@angular/core';
import{FormGroup , FormControl,Validator, Validators, FormBuilder}from'@angular/forms'
import { AuthModel } from 'src/app/Models/iauth-model';
import { AuthService } from './../../../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;
  submitted = false;
  constructor(private formBuilder: FormBuilder,private authsrvc:AuthService,private router:Router) { }

  ngOnInit(): void {
    if(localStorage.getItem("rntoken"))
      this.router.navigateByUrl("/Home")
      this.loginForm = this.formBuilder.group({
      Email: ['', [Validators.required, Validators.email]],
      Password:['', [Validators.required]]
  });
  }
  onSubmit() {
    this.submitted = true;
    if (this.loginForm.invalid) {
        return;
    }
    this.authsrvc.login(this.loginForm.value).subscribe(
      res=>{
        var resp = res as AuthModel;
        localStorage.setItem("rnid", resp.id)
        localStorage.setItem("rntoken", resp.token)
        localStorage.setItem("rnemail", resp.email)
        localStorage.setItem("rnroles", JSON.stringify(resp.roles))
        this.router.navigateByUrl("/Home")
      },
      err=> alert("هناك خطأ في ادخال الايميل أو كلمة المرور - برجاء اعادة المحاولة")
      )
}
onReset() {
  this.submitted = false;
  this.loginForm.reset();
}
}
