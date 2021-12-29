import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Comment } from 'src/app/Models/comment';

@Injectable({
  providedIn: 'root'
})
export class LessonCommentService {

  constructor(private http:HttpClient) { }

  private URL="https://elearningbackendapi.azurewebsites.net/api/";

  getAll(id:number){
    return this.http.get(this.URL+"lessonComment/"+id)
  }

  Comment(comment){
    return this.http.post(this.URL+"lessonComment",comment);
  }

}
