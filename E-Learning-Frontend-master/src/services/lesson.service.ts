import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Lesson } from './../app/Models/lesson';

@Injectable({
  providedIn: 'root'
})
export class LessonService {
  private URL="https://elearningbackendapi.azurewebsites.net/"

  constructor(private lessonClient: HttpClient) { }
  getByID(id:number){
    return this.lessonClient.get(this.URL+"api/lesson/"+id)
  }
  getSome(){
    return this.lessonClient.get(this.URL+"api/lesson/lesson")
  }
  getlsnsByCrsId(id:number){
    return this.lessonClient.get(this.URL+"api/lesson/course/"+id)
  }
  getAll(){
    return this.lessonClient.get(this.URL+"api/lesson")
  }
  getRelated(id:number){
    return this.lessonClient.get(this.URL+"api/lesson/topic/"+id)
  }

  update(lsn:Lesson){

    return this.lessonClient.put<Lesson>(this.URL+"api/lesson",lsn)
  }
}
