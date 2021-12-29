import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs/internal/Subscription';
import { LessonService } from 'src/services/lesson.service';

@Component({
  selector: 'app-secondsection',
  templateUrl: './secondsection.component.html',
  styleUrls: ['./secondsection.component.css']
})
export class SecondsectionComponent implements OnInit {
  lesson:any;

  constructor(private lsnService:LessonService,private route:ActivatedRoute) { }
  ngOnInit(): void {
    this.lsnService.getSome().subscribe(
      (res)=>{this.lesson=res;},
      (err)=>{console.log(err)}
    )
  }

}
