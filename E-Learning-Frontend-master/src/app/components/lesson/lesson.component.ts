import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { Lesson } from 'src/app/Models/lesson';
import { LessonService } from './../../../services/lesson.service';
import { Exam } from 'src/app/Models/exam';
import { Title } from '@angular/platform-browser';
import { Article } from './../../Models/article';
import { ArticleService } from 'src/services/article.service';

@Component({
  selector: 'app-lesson',
  templateUrl: './lesson.component.html',
  styleUrls: ['./lesson.component.css']
})
export class LessonComponent implements OnInit,AfterViewInit {

  @ViewChild("video") videoUrl:any;
  id:number;
  lessons:Lesson[];
  lesson:Lesson;
  private subscriptions: Subscription[] = [];
  relatedLessons:Lesson[]
  relatedArticles: Article[]



  constructor(private articlSrvc:ArticleService,private lsnService:LessonService,private route:ActivatedRoute,private title:Title) {
    // this.id = route.snapshot.params["id"];

   }

  ngOnInit(): void {
    var subscription1
    var subscription2
    var subscription3
    var subscription4

    subscription3= this.route.paramMap.subscribe(
      (params)=>{
        this.id=parseInt(params.get("id"))
        subscription1 =  this.lsnService.getByID(this.id).subscribe(
          (res)=>{this.lesson=res as Lesson ;
            this.title.setTitle(this.lesson.title)
            this.lsnService.getlsnsByCrsId(this.lesson.courseId).subscribe(
              (res)=>{this.lessons=res as Lesson[] ;

                let link = "https://www.youtube.com/embed/"+this.lesson.link+"?controls=1&fs=1&rel=0"
                this.videoUrl.nativeElement.innerHTML =`<iframe height="100%" width="100%" src=${link}>
                </iframe>`
              },
              (err)=>console.log(err)
            )
          },
          (err)=>console.log(err)
        )
        subscription2=this.lsnService.getRelated(this.id).subscribe(
          res=> this.relatedLessons= res as Lesson[],
          err=>console.log(err)
        )

        subscription4=this.articlSrvc.getRelated(this.id).subscribe(
          res=> this.relatedArticles = res as Article[],
          err=>console.log(err)
        )
    }

      ,(err)=>console.log(err)

    )


    this.subscriptions.push(subscription1,subscription3,subscription2,subscription4)
  }

  ngAfterViewInit(): void {


    }

    ngOnDestroy(): void {
      for(let sub of this.subscriptions){
        sub.unsubscribe()
      }
      }


}
