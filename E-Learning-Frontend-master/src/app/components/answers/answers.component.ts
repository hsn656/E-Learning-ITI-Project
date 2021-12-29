import { AfterViewInit, Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { QuestionService } from 'src/services/question.service';
import * as moment from 'moment';
import { Subscription } from 'rxjs';
import { Post } from 'src/app/Models/post';
import { Comment } from 'src/app/Models/comment';
import { AnswerService } from 'src/services/answer.service';
import * as signalR from '@microsoft/signalr';

@Component({
  selector: 'app-answers',
  templateUrl: './answers.component.html',
  styleUrls: ['./answers.component.css'],
})
export class AnswersComponent implements AfterViewInit, OnDestroy, OnInit {
  id: number = 0;
  private subscriptions: Subscription[] = [];

  // allAnswers: any = [];
  questions: Post;
  otherAnswers: Comment[];

  bestAnswer: Comment;
  answer: string = '';

  asideQuestions:Post[]

  constructor(
    private qService: QuestionService,
    private myService: AnswerService,
    private activated: ActivatedRoute,
    private router: Router
  ) {
    this.activated.paramMap.subscribe(params => {
      this.id = parseInt(params.get('id'));
      this.ngOnInit();
    });
    // this.id = activated.snapshot.params['id'];


  }
  ngOnInit(): void {
    this.getquestionWithAnswers();
    this.getquestionsWithLimited();

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
        this.getquestionWithAnswers();
      });
  }

  ngAfterViewInit(): void {
    this.setViewCount(this.id);
  }
  ngOnDestroy(): void {
    for (let sub of this.subscriptions) {
      sub.unsubscribe();
    }
  }
  checkToken(){
    return localStorage.getItem("rntoken")
  }
  getquestionWithAnswers() {
    this.subscriptions.push(
      this.qService.getByID(this.id).subscribe(
        (res) => {
          this.questions = res as Post
          this.bestAnswer = this.questions.comments.sort(this.sortArray)[0];
          this.otherAnswers = this.questions.comments
          this.otherAnswers.shift()
        },
        (err) => console.error(err)
      )
    );
  }


  getImg(image){
    return image==null ? "assets/images/person-icon.png" : "https://elearningbackendapi.azurewebsites.net/"+image
  }

  getquestionsWithLimited() {
    this.subscriptions.push(
      this.qService.getAllWithLimited(this.id).subscribe(
        (res) => {
          this.asideQuestions = res as Post[]
        },
        (err) => console.error(err)
      )
    );
  }

  sortArray(a:Comment, b:Comment):number{
      // return a.commentLikes - b.commentLikes
      if (a.commentLikes > b.commentLikes) {
        return -1;
      }
      if (a.commentLikes < b.commentLikes) {
        return 1;
      }
      return 0;
  }

  getEstimatedDate(date: string): string {
    return moment(date).locale('ar').fromNow();
  }

  setViewCount(id: number) {
    let question = [
      {
        value: this.questions.views + 1,
        path: "/views",
        op: "replace",
      }
    ];
    this.subscriptions.push(
      this.qService.updateViewCount(id, question).subscribe(
        (res) => console.log("done!!!"),
        (err) => console.error(err)
      )
    );
  }

  increaseEval(up: HTMLElement, down: HTMLElement) {
    if (!up.classList.contains('text-muted')) {
      let like={
        postId: this.id,
        userId: localStorage.getItem("rnid")
      }
      this.subscriptions.push(
      this.qService.updateLike(this.id, like).subscribe(
        (res) => {
          this.getquestionWithAnswers()
          // up.classList.add('text-muted');
          // down.classList.remove('text-muted');
        },
        (err) => console.error(err)
      ))
    }
  }

  decreaseEval(up: HTMLElement, down: HTMLElement) {
    if (!down.classList.contains('text-muted')) {
      let like={
        postId: this.id,
        userId: localStorage.getItem("rnid")
      }
      this.subscriptions.push(
      this.qService.updateDisLike(this.id, like).subscribe(
        (res) => {
          this.getquestionWithAnswers()

          // down.classList.add('text-muted');
          // up.classList.remove('text-muted');
        },
        (err) => console.error(err)
      ))
    }

  }
  ////////////////////////////////////////////////////
  increaseAnsEval(id: number, up: HTMLElement, down: HTMLElement) {
    if (!up.classList.contains('text-muted')) {
      let like={
        commentId: id,
        userId: localStorage.getItem("rnid")
      }
      this.subscriptions.push(
      this.myService.updateLike(id, like).subscribe(
        (res) => {
          this.getquestionWithAnswers()

          // down.classList.add('text-muted');
          // up.classList.remove('text-muted');
        },
        (err) => console.error(err)
      ))
    }
  }

  decreaseAnsEval(id: number, up: HTMLElement, down: HTMLElement) {
    if (!down.classList.contains('text-muted')) {
      let like={
        commentId: id,
        userId: localStorage.getItem("rnid")
      }
      this.subscriptions.push(
      this.myService.updateDisLike(id, like).subscribe(
        (res) => {
          this.getquestionWithAnswers()

          // down.classList.add('text-muted');
          // up.classList.remove('text-muted');
        },
        (err) => console.error(err)
      ))
    }
  }
  ////////////////////////////////////////////////////
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

  ////////////////////////////////////////////////////
  currentUserCommentLike(data:Comment){
    if(data.commentLikesArr.length==0||data.commentLikesArr==undefined||data.commentLikes==0){
      return false
    }
    return data.commentLikesArr.includes(localStorage.getItem("rnid"))
  }

  currentUserCommentDisLike(data:Comment){
    if(data.commentDisLikesArr.length==0||data.commentDisLikesArr==undefined||data.commentLikes==0){
      return false
    }
    return data.commentDisLikesArr.includes(localStorage.getItem("rnid"))
  }
  ////////////////////////////////////////////////////


  AddData() {
    if(this.answer.trim()!=""){
    let answerObj: any = {
      content: this.answer,
      postId: this.id,
      userId: localStorage.getItem("rnid")
    };

    this.myService.add(answerObj).subscribe(
      (res)=>{
        // console.log(res)
        this.answer=""
        this.getquestionWithAnswers()
      },
      (err)=>console.error(err)
    )
  }
}
}
