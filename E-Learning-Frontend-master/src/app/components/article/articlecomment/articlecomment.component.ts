import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { LessonCommentService } from './../../../../services/lesson-comment.service';
import { articleComment } from './../../../Models/articleComment';
import { Subscription } from 'rxjs/internal/Subscription';
import { ActivatedRoute } from '@angular/router';
import * as signalR from '@microsoft/signalr';
import { AuthService } from 'src/services/auth.service';
import { stringify } from '@angular/compiler/src/util';
import { AuthModel } from 'src/app/Models/iauth-model';
import * as moment from 'moment';

@Component({
  selector: 'app-articlecomment',
  templateUrl: './articlecomment.component.html',
  styleUrls: ['./articlecomment.component.css']
})
export class ArticlecommentComponent implements OnInit {

  comments:any[];
  commentContent:string='';
  err:string;
  sub:Subscription;
  sub2:Subscription;
  id:number;
  user:any;
  userName:string;
  userImg:string;
  usersId:Array<any>;



  @ViewChild('#txtArea') txtArea:ElementRef;

  constructor(private LessonComment:LessonCommentService,route: ActivatedRoute ,private userservice:AuthService) {
      this.id = route.snapshot.params.id;

   }

   IsLogged(){
    return !localStorage.getItem('rnemail')
   }

  addComment(){
    if(this.commentContent.trim()!=""){
    let newComment ={
      lessonId:this.id,
      userId: localStorage.getItem("rnid"),
      content:this.commentContent
    };
    this.sub2 = this.LessonComment.Comment(newComment).subscribe({
      next: res=>{
        newComment=null;
        this.commentContent='';

      },
      error: (err) => (this.err = err),
    })
    }
  }

  getEstimatedDate(date: string): string {
    return moment(date).locale('ar').fromNow();
  }

  getData(){
    this.sub=this.LessonComment.getAll(this.id).subscribe({
      next: res=>{
        this.comments =res as articleComment[]
      },
      error: (err) => (this.err = err),
    })
  }

  ngOnInit(): void {
    this.getData();
    // console.log(this.user.id)

    const connection = new signalR.HubConnectionBuilder()
    .configureLogging(signalR.LogLevel.Information)
    .withUrl("https://elearningbackendapi.azurewebsites.net/notify")
    .build();

    connection.start().then(function () {
      console.log('SignalR Connected!');
    }).catch(function (err) {
      return console.error(err.toString());
    });

    connection.on("comment", () => {
      this.getData();
    });

  }


}
