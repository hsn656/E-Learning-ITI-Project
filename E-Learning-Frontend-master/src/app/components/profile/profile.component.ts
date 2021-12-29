import { HttpEventType } from '@angular/common/http';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthService } from 'src/services/auth.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  constructor(private athservice: AuthService) { }
  updateForm: FormGroup;
  user:any
  currentPassword:string
  newPassword:string
  email:string

  @Output() public onUploadFinished = new EventEmitter();
  ngOnInit(): void {
    this.getUser()

  }

  getUser(){
    this.athservice.getUserData(localStorage.getItem("rnid")).subscribe(
      res=>{
        this.user=res
        this.email=this.user.email
        // console.log(this.user)
      },
      err=>console.error(err)
    )
  }


  updatePassword(){
    let user:any={
      userId: localStorage.getItem("rnid"),
      currentPassword: this.currentPassword,
      newPassword: this.newPassword
    }
    this.athservice.changePassword(user).subscribe(
      res=>{
        alert("تم التعديل بنجاح")
      },
      err=>alert(err.error)
    )
  }

  updateEmail(){
    let user:any={
      userId: localStorage.getItem("rnid"),
      email: this.email
    }
    this.athservice.changeEmail(user).subscribe(
      res=>{
        alert("تم التعديل بنجاح")
      },
      err=>alert(err.error)
    )
  }

  getImg(img): string{
    if(img==null) {
      localStorage.removeItem("rnimage")
      return "assets/images/person-icon.png"
    } else { return "https://elearningbackendapi.azurewebsites.net/"+img}
  }

  uploadPhoto(files, image:HTMLElement){
    image.setAttribute("src", 'assets/images/Youtube_loading_symbol_1_(wobbly).gif')
    if (files.length === 0) {
      return;
    }
    let fileToUpload = <File>files[0];
    const formData = new FormData();
    formData.append('file', fileToUpload, fileToUpload.name);
    this.athservice.addImage(formData, localStorage.getItem("rnid"))
      .subscribe(event => {
        console.log(event)
        if (event.type === HttpEventType.Response) {
          alert('تم الرفع بنجاح')
          this.setPhoto(image, event.body)
          // this.onUploadFinished.emit(event.body);
        }
      },
      err => console.error(err));
  }

  setPhoto(image:HTMLElement, event){
    image.setAttribute("src", "https://elearningbackendapi.azurewebsites.net/"+event.dbPath)
    localStorage.setItem("rnimage", event.dbPath)

  }


  onSubmit(){
    this.athservice.updateUserData(this.user).subscribe(
      res=> alert("تم التعديل بنجاح"),
      err=> console.error(err.error)
    )
  }
}
