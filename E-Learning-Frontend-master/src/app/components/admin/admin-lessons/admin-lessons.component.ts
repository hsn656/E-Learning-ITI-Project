import { Component, OnInit } from '@angular/core';
import { Lesson } from 'src/app/Models/lesson';
import { LessonService } from 'src/services/lesson.service';

@Component({
  selector: 'app-admin-lessons',
  templateUrl: './admin-lessons.component.html',
  styleUrls: ['./admin-lessons.component.css']
})
export class AdminLessonsComponent implements OnInit {

  lessons:Lesson[];

  constructor(private lsnService:LessonService) { }

  ngOnInit(): void {
    this.lsnService.getAll().subscribe(
      res=>this.lessons = res as Lesson[],
      err=>console.log(err)
    )
  }

}
