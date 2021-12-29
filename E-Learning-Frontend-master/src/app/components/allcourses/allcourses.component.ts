import { Component, OnInit, OnDestroy } from '@angular/core';
import { Course } from 'src/app/Models/course';
import { CoursedetailesService } from 'src/services/coursedetailes.service';
import { Subscription } from 'rxjs/internal/Subscription';

@Component({
  selector: 'app-allcourses',
  templateUrl: './allcourses.component.html',
  styleUrls: ['./allcourses.component.css']
})
export class AllcoursesComponent implements OnInit ,OnDestroy{
  courses:Course[]=[];
  sub:Subscription;
  err: string = '';
  filteredCourse:Course[]=[];

  private _listfilter:string='';
  get listfilter():string{
    return this._listfilter;
  }
  set listfilter(value:string){
    this._listfilter=value;
    console.log(value);
    this.filteredCourse=this.performFilter(value);
  }

  constructor(private CourseService: CoursedetailesService) { }
  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }


  performFilter(filterby:string):Course[]{
      filterby=filterby.toLowerCase();
      return this.courses.filter((crs:Course)=>{
        crs.name.toLowerCase().includes(filterby);
      })
  }

  showcrs(e: any): void {
    if (e.target.value !== '') {
      let newData = this.courses.filter((crs: Course) => {
        return crs.name.includes(e.target.value);
      });
      this.filteredCourse = newData;
    } else {
      this.filteredCourse = this.courses;
    }
    // console.log(e.target.value);
  }
  ngOnInit(): void {
    this.sub = this.CourseService.getAll().subscribe({
      next: res => {
        this.courses = res as Course[];
        this.filteredCourse=this.courses;
      },
      error: err => (this.err = err),
    });
    this.listfilter="";
  }

}
