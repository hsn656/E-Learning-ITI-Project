import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AnswerService {


  constructor(private myClient: HttpClient) { }
  private URL="https://elearningbackendapi.azurewebsites.net/api/Comment"


  updateLike(id:number, answer:any){
    return this.myClient.post(this.URL+"/like/"+id,answer)
  }

  updateDisLike(id:number, answer:any){
    return this.myClient.post(this.URL+"/dislike/"+id,answer)
  }

  // getAllByQuestion(id:number){
  //   return this.myClient.get(`${this.URL}?questionID=${id}`)
  // }

  add(answer:any){
    return this.myClient.post(this.URL,answer)
  }

  // update(id:number, answer:any){
  //   return this.myClient.put(this.URL+"/"+id,answer)
  // }

}
