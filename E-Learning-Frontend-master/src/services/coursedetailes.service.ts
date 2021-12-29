import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CoursedetailesService {

  constructor(private http:HttpClient) { }

  private URL="https://elearningbackendapi.azurewebsites.net/api/";


  getByID(id:number){
    return this.http.get(this.URL+"course/"+id)
  }
  getSomeCourses(){
    return this.http.get(this.URL+"course/course")
  }

  getAll(){
    return this.http.get(this.URL+"course")
   }
}
