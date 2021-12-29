import { Component, OnInit, Renderer2, ViewChild, OnDestroy } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { Exam } from 'src/app/Models/exam';
import { ExamService } from './../../../services/exam.service';

@Component({
  selector: 'app-exam',
  templateUrl: './exam.component.html',
  styleUrls: ['./exam.component.css']
})
export class ExamComponent implements OnInit,OnDestroy{
  exam:Exam;
  private subscriptions: Subscription[];
  degree:number=-1;
  @ViewChild("Questions") Questions:any;
  id:number;

  constructor(private examService: ExamService,route:ActivatedRoute,private renderer:Renderer2) {
    this.id = route.snapshot.params["id"];
   }


  ngOnInit(): void {
   var subscription =  this.examService.getByID(this.id).subscribe(
      (res)=>this.exam=res as Exam ,
      (err)=>console.log(err)
    )

    // this.subscriptions.push(subscription)
  }

  ngOnDestroy(): void {
    // for(let sub of this.subscriptions){
    //   sub.unsubscribe()
    // }
    }

  calc(){
    this.degree=0;

    for(let i=0;i<this.Questions.nativeElement.children.length-1;i++){
        let question = this.Questions.nativeElement.children[i];

        for (let j=1;j<question.children.length;j++){
          let opt =question.children[j].children[0]

          if(opt.checked){
            this.renderer.setStyle(question.children[j],"backgroundColor","#ef3138")
          }

          if(opt.dataset.ans=="true"){
            this.renderer.setStyle(question.children[j],"backgroundColor","#27df99")
          }

          if(opt.checked && opt.dataset.ans=="true" ){
            this.degree++;
          }

        }
    }
}


}
