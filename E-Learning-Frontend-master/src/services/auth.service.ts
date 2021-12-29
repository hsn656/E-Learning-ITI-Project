import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private client:HttpClient) { }

  private URL="https://elearningbackendapi.azurewebsites.net/api/";

  Register(user){
    return this.client.post(this.URL+"Auth/register",user)
  }

  ///////////////////////////////////////
  changePassword(user){
    return this.client.post(this.URL+"Auth/changePassword",user)
  }

  changeEmail(user){
    return this.client.post(this.URL+"Auth/changeEmail",user)
  }

  login(user){
    return this.client.post(this.URL+"Auth/login",user)
  }

  getUserData(id:string){
    return this.client.get(this.URL+"User/"+id)
  }

  updateUserData(user){
    return this.client.put(this.URL+"User", user)
  }

  addImage(formData, userId){
    return this.client.post(this.URL+"Auth/Image/"+userId, formData, {reportProgress: true, observe: 'events'})
  }
}
