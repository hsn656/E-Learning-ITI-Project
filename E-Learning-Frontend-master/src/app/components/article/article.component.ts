import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Subscription } from 'rxjs';
import { Article } from 'src/app/Models/article';
import { ArticleService } from 'src/services/article.service';
import { ActivatedRoute } from '@angular/router';
import { LessonService } from 'src/services/lesson.service';
import { Lesson } from 'src/app/Models/lesson';

@Component({
  selector: 'app-article',
  templateUrl: './article.component.html',
  styleUrls: ['./article.component.css']
})
export class ArticleComponent implements OnInit {

  id:number;
  lesson:Article;
  Content:string="";
  Title:string="";
  sub!:Subscription;
  relatedLessons:Lesson[]
  relatedArticles: Article[]

  @ViewChild("#Con") p:ElementRef;
  constructor(private articlSrvc:ArticleService,private lsnService:LessonService, private article:ArticleService,private route:ActivatedRoute) { }


  ngOnInit(): void {

    this.route.paramMap.subscribe(
      params=>{
        this.id= parseInt(params.get("id"))
      this.article.getByID(this.id).subscribe({
        next: res=>{
          this.lesson=res as Article;
          this.Title=this.lesson.title;
          this.Content=this.lesson.content;

          this.lsnService.getRelated(this.lesson.id).subscribe(
            res=> this.relatedLessons= res as Lesson[],
            err=>console.log(err)
          )
         this.articlSrvc.getRelated(this.lesson.id).subscribe(
            res=> this.relatedArticles = res as Article[],
            err=>console.log(err)
          )
        }
      })
      }
    )


  }

}
