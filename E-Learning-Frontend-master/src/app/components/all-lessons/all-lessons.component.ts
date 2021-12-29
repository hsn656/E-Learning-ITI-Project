import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Lesson } from 'src/app/Models/lesson';
import { LessonService } from 'src/services/lesson.service';

@Component({
  selector: 'app-all-lessons',
  templateUrl: './all-lessons.component.html',
  styleUrls: ['./all-lessons.component.css']
})
export class AllLessonsComponent implements OnInit {
  lessons:Lesson[];
  copylessons:Lesson[];
  constructor(private lsnService:LessonService,private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.lsnService.getAll().subscribe(
      (res)=>{
        this.lessons=res as Lesson[];
        this.copylessons=res as Lesson[]},
      (err)=>{console.log(err)}
    )
  }

  ReBind(e: any): void {
    if (e.target.value !== '') {
      let newData = this.copylessons.filter((lsn:Lesson) => {
        return lsn.title.includes(e.target.value);
      });
      this.copylessons = newData;
    } else {
      this.copylessons = this.lessons;
    }
  }

}
