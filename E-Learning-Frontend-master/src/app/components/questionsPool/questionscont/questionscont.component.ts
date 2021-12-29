import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { Question } from 'src/app/Models/question';
import { ExamService } from 'src/services/exam.service';

@Component({
  selector: 'app-questionscont',
  templateUrl: './questionscont.component.html',
  styleUrls: ['./questionscont.component.css']
})
export class QuestionscontComponent implements OnInit, OnChanges {

  constructor(private examService: ExamService) { }
  @Input() topicId:number;
  examQuestions:Question[]
  copiedExamQuestions:Question[]
  correctAnswer:string

  ngOnChanges(): void {
    console.log(this.topicId)
    if(this.topicId==0){
      this.examQuestions=this.copiedExamQuestions
    }else{
      this.examQuestions=this.copiedExamQuestions.filter(q=>{
        if(q.topicId.includes(this.topicId))
          return q
        return null
      })
    }
  }
  //just for test
  // favoriteSeason: string;
  // seasons: string[] = ['الاجابة الاولي', 'الاجابة الثانية', 'الاجابة الثالثة', 'الاجابة الرابعة'];

  ngOnInit(): void {
    this.getAllQuestions()
  }

  getAllQuestions(){
    this.examService.getAllQuestionsForExam().subscribe(
      res=>{
        this.examQuestions = res as Question[]
        this.copiedExamQuestions = res as Question[]
      },
      err=>console.error(err)
    )
  }

  trueOrFalse(optionId:number, questionId:number, btnModal:HTMLElement){
    this.examQuestions.filter(e=>{
      if(e.id==questionId){
        this.correctAnswer = e.options.find(op=>op.isCorrect).content
      }
    })
    this.examQuestions.map(e=>{
      e.options.forEach(op=>{

        if(op.optionId==optionId){
          if(op.isCorrect)
            btnModal.setAttribute('data-target','#exampleModal')
          else{
            btnModal.setAttribute('data-target','#exampleModal_2')
          }
        }
      })
    })
  }
}
