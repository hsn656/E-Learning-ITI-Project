import {
  Component,
  ElementRef,
  OnChanges,
  OnDestroy,
  OnInit,
  SimpleChanges,
} from '@angular/core';
import { QuestionService } from 'src/services/question.service';
import * as moment from 'moment';
import { Subscribable, Subscription } from 'rxjs';
import { Post } from 'src/app/Models/post';
import { Router } from '@angular/router';
import * as signalR from '@microsoft/signalr';


@Component({
  selector: 'app-questions',
  templateUrl: './questions.component.html',
  styleUrls: ['./questions.component.css'],
})

export class QuestionsComponent implements OnInit, OnDestroy {
  constructor(private myService: QuestionService, private router: Router) {}
  ngOnDestroy(): void {
    for(let sub of this.subscriptions){
      sub.unsubscribe()
    }

  }
  private subscriptions: Subscription[] = [];
  question = '';
  questions: Post[]
  copiedQuestions: Post[]
  ngOnInit(): void {
    this.getAllData();

    const connection = new signalR.HubConnectionBuilder()
    .configureLogging(signalR.LogLevel.Information)
    .withUrl("https://elearningbackendapi.azurewebsites.net/notify")
    .build();

    connection.start().then(function () {
      console.log('SignalR Connected!');
    }).catch(function (err) {
      return console.error(err.toString());
    });

    connection.on("broadcast", () => {
      this.getAllData();
    });
  }
  checkToken(){
    return localStorage.getItem("rntoken")
  }
  gotoLogin(exitModal:HTMLElement){
    exitModal.click()
    this.router.navigateByUrl("/login")
  }
  getAllData() {
    this.subscriptions.push(
      this.myService.getAll().subscribe(
        (res) => {
          this.questions = res as Post[];
          this.copiedQuestions = res as Post[];
        },
        (err) => console.error(err)
      )
    )
  }

  getImg(image){
    return image==null ? "assets/images/person-icon.png" : "https://elearningbackendapi.azurewebsites.net/"+image
  }

  ReBind(e: any): void {
    if (e.target.value !== '') {
      let newData = this.questions.filter((p: Post) => {
        return p.content.includes(e.target.value);
      });
      this.copiedQuestions = newData;
    } else {
      this.copiedQuestions = this.questions;
    }
    // console.log(e.target.value);
  }
  getEstimatedDate(date: string): string {
    return moment(date).locale('ar').fromNow();
  }

  increaseEval(id: number, up: HTMLElement, down: HTMLElement) {
    if (!up.classList.contains('text-muted')) {
      let like={
        postId: id,
        userId: localStorage.getItem("rnid")
      }
      this.subscriptions.push(
      this.myService.updateLike(id, like).subscribe(
        (res) => {
          // this.questions = res as Post[];
          // this.copiedQuestions = res as Post[];
          // up.classList.add('text-muted');
          // down.classList.remove('text-muted');
        },
        (err) => console.error(err)
      ))
    }
  }

  decreaseEval(id: number, up: HTMLElement, down: HTMLElement) {
    if (!down.classList.contains('text-muted')) {
      let like={
        postId: id,
        userId: localStorage.getItem("rnid")
      }
      this.subscriptions.push(
      this.myService.updateDisLike(id, like).subscribe(
        (res) => {
          // this.questions = res as Post[];
          // this.copiedQuestions = res as Post[];
          // down.classList.add('text-muted');
          // up.classList.remove('text-muted');
        },
        (err) => console.error(err)
      ))
    }
  }

  currentUserLike(data:Post){
    if(data.postLikesArr.length==0||data.postLikesArr==undefined||data.postLikes==0){
      return false
    }
    return data.postLikesArr.includes(localStorage.getItem("rnid"))
  }

  currentUserDisLike(data:Post){
    if(data.postDisLikesArr.length==0||data.postDisLikesArr==undefined){
      return false
    }
    return data.postDisLikesArr.includes(localStorage.getItem("rnid"))
  }

  Add(btnExit:HTMLElement) {
    let question: any = {
      content: this.question,
      userId: localStorage.getItem("rnid")
    };
    this.subscriptions.push(
    this.myService.add(question).subscribe(
      (res) => {
        btnExit.click()
        this.question=""
        // this.getAllData()
      },
      (err) => console.error(err)
    ))
  }
}
