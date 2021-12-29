import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CoursedetailesService } from 'src/services/coursedetailes.service';

@Component({
  selector: 'app-fourthsection',
  templateUrl: './fourthsection.component.html',
  styleUrls: ['./fourthsection.component.css']
})
export class FourthsectionComponent implements OnInit {
  crs:any;
  constructor(private crsservice:CoursedetailesService,private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.crsservice.getSomeCourses().subscribe(
      (res)=>{this.crs=res;},
      (err)=>{console.log(err)}
    )
  }

}
