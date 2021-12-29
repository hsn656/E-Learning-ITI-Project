import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Course } from 'src/app/Models/course';
import { Lesson } from 'src/app/Models/lesson';
import { LessonService } from 'src/services/lesson.service';
import { CoursedetailesService } from './../../../../../services/coursedetailes.service';

@Component({
  selector: 'app-edit-lesson',
  templateUrl: './edit-lesson.component.html',
  styleUrls: ['./edit-lesson.component.css']
})
export class EditLessonComponent implements OnInit {

  lsn:Lesson;
  id:number;
  courses:Course[];
  @ViewChild("selectBox") selectBox:any;


  constructor(
    private lsnService:LessonService
    ,private ActiveLink:ActivatedRoute
    ,private router:Router
    ,private crsSrvice:CoursedetailesService
    ) { }

  ngOnInit(): void {
    this.lsnService.getByID(this.ActiveLink.snapshot.params.id).subscribe(
      resp=>{
        this.lsn=resp as Lesson,
      this.id=this.lsn.courseId}
      ,
      err=>console.log(err)
    )
    this.crsSrvice.getAll().subscribe(
      resp=>this.courses=resp as Course[],
      err=>console.log(err)
    )
  }
  update(){
    this.lsn.courseId = this.id
    this.lsnService.update(this.lsn).subscribe(
     (rep)=> console.log(rep),
     err=>console.log(err)
    )
  }
  changeId(){
     this.id =this.selectBox.nativeElement.value;
  }


}
