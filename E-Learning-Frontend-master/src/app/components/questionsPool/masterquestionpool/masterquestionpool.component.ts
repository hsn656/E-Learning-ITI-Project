import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-masterquestionpool',
  templateUrl: './masterquestionpool.component.html',
  styleUrls: ['./masterquestionpool.component.css']
})
export class MasterquestionpoolComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  topicId:number

  gotoParent(e){
    this.topicId=e
  }
}
