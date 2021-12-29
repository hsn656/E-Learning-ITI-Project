import { stringify } from '@angular/compiler/src/util';
import { Component, OnInit } from '@angular/core';
import{FormGroup , FormControl,Validator, Validators, FormBuilder}from'@angular/forms'
import { AuthService } from './../../../services/auth.service';
import { AuthModel } from './../../Models/iauth-model';
import { Router } from '@angular/router';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  registerForm: FormGroup;
  submitted = false;




  constructor(private formBuilder: FormBuilder,private authsrvc:AuthService,private router:Router) { }

  ngOnInit(): void {

    if(localStorage.getItem("rntoken"))
      this.router.navigateByUrl("/Home")

  this.registerForm = this.formBuilder.group({
    FirstName: ['', [Validators.required,Validators.minLength(3)]],
    LastName: ['',[ Validators.required,Validators.minLength(3)]],
    Email: ['', [Validators.required, Validators.email]],
    Password: ['', [Validators.required, Validators.minLength(6),Validators.pattern(/^(?=\D*\d)(?=[^a-z]*[a-z])(?=.*[$@$!#%*?&])(?=[^A-Z]*[A-Z]).{8,30}$/)]],
    confirmPassword: ['', Validators.required],
    PhoneNumber:['',[Validators.required,Validators.pattern(/^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$/)]]
  }, {
    validator: this.MustMatch('Password', 'confirmPassword')
  });
  }
get f() { return this.registerForm.controls; }

onSubmit() {
    this.submitted = true;
    if (this.registerForm.invalid) {
        return;
    }

  this.authsrvc.Register(this.registerForm.value).subscribe(
    res=>{
      var resp = res as AuthModel;
      localStorage.setItem("rnid", resp.id)
      localStorage.setItem("rntoken", resp.token)
      localStorage.setItem("rnemail", resp.email)
      localStorage.setItem("rnroles", JSON.stringify(resp.roles))
      this.router.navigateByUrl("/Home")
    },
    err=>alert(err.error)
  )
}

onReset() {
    this.submitted = false;
    this.registerForm.reset();
}

  MustMatch(controlName: string, matchingControlName: string) {
  return (formGroup: FormGroup) => {
      const control = formGroup.controls[controlName];
      const matchingControl = formGroup.controls[matchingControlName];

      if (matchingControl.errors && !matchingControl.errors.mustMatch) {
          return;
      }
      if (control.value !== matchingControl.value) {
          matchingControl.setErrors({ mustMatch: true });
      } else {
          matchingControl.setErrors(null);
      }
  }
}
}

