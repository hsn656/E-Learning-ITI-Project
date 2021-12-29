import { Component, OnInit, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs';
import { CoursedetailesService } from './../../../services/coursedetailes.service';
import { ActivatedRoute } from '@angular/router';
import { Course } from 'src/app/Models/course';
import { Lesson } from 'src/app/Models/lesson';

@Component({
  selector: 'app-coursedetailes',
  templateUrl: './coursedetailes.component.html',
  styleUrls: ['./coursedetailes.component.css'],
})
export class CoursedetailesComponent implements OnInit, OnDestroy {
  course: Course;
  id: number;
  courses: Course[];
  Description: string = '';
  Content: Lesson[] = [];
  Title: string = '';
  Auther: string = 'حسن محمد';
  CourseImage: string = '';
  err: string = '';

  sub!: Subscription;
  sub2!: Subscription;

  constructor(
    private CourseService: CoursedetailesService,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    var subscription3;
    subscription3 = this.route.params.subscribe(
      (params) => {
        this.id = params['id'];

        this.sub = this.CourseService.getByID(
          Number(this.route.snapshot.paramMap.get('id'))
        ).subscribe(
          (res) => {
            this.course = res as Course;
            this.Description = this.course.description;
            this.Title = this.course.name;
            this.Content = this.course.lessons;
            this.CourseImage = this.course.image;

            this.sub2 = this.CourseService.getSomeCourses().subscribe({
              next: (res) => {
                this.courses = res as Course[];
              },
              error: (err) => (this.err = err),
            });
          },
          (err) => (this.err = err)
        );
      },
      (err) => (this.err = err)
    );
  }
  ngOnDestroy(): void {
    this.sub.unsubscribe();
    this.sub2.unsubscribe();
  }
}
