import {Component, EventEmitter, OnChanges, OnDestroy, OnInit, Output, SimpleChanges} from '@angular/core';
import {FormControl} from '@angular/forms';
import {Observable, Subscription} from 'rxjs';
import {map, startWith} from 'rxjs/operators';
import { TopicView } from 'src/app/Models/topic';
import { ExamService } from 'src/services/exam.service';

@Component({
  selector: 'app-questionfilter',
  templateUrl: './questionfilter.component.html',
  styleUrls: ['./questionfilter.component.css']
})
export class QuestionfilterComponent implements OnInit, OnDestroy, OnChanges {

  constructor(private examService:ExamService) {
  }

  ngOnChanges(changes: SimpleChanges): void {
    throw new Error('Method not implemented.');
  }

  private subscriptions: Subscription[] = [];
  //to test
  myControl = new FormControl();
  options: TopicView[]
  filteredOptions: Observable<TopicView[]>;

  inputContent:string
  @Output() sendTopicId = new EventEmitter();

  ngOnDestroy(): void {
    for (let sub of this.subscriptions) {
      sub.unsubscribe();
    }
  }

  ngOnInit() {
    this.getAllTopics()

    // this.filteredOptions = this.myControl.valueChanges
    //   .pipe(

    //     map(value => this.options)
    //   );
  }

  // private _filter(value:string): TopicView[] {
  //   console.log(value)
  //   const filterValue = value
  //   this.sendTopicId.emit(value)
  //   // if(value)
  //   return this.options.filter(p=>{
  //     if(p.title.indexOf(value)!=-1)
  //       return p
  //     return null
  //   })
  //   // return this.options;
  // }

  getId(e){
    let res = this.options.filter(p=>{
      if(p.title.includes(e.target.innerHTML.trim()))
        return p
      return null
    })
    this.sendTopicId.emit(res[0].id)
  }

  getAllTopics(){
    this.subscriptions.push(
      this.examService.getAllTopics().subscribe(
        res=>{
          this.options=res as TopicView[]
        },
        err=>console.error(err)
      ))
  }

  sendEvent(){
    if(this.inputContent=="")
      this.sendTopicId.emit(0)
  }
}
