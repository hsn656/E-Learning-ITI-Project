import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminHomeComponent } from './admin-home/admin-home.component';
import { AdminLessonsComponent } from './admin-lessons/admin-lessons.component';
import { RouterModule } from '@angular/router';
import { EditLessonComponent } from './admin-lessons/edit-lesson/edit-lesson.component';
import { FormsModule } from '@angular/forms';


const routes = [
  {path:"home",component:AdminHomeComponent},
  {path:"lesson",component:AdminLessonsComponent},
  {path:"editLesson/:id",component:EditLessonComponent},
  {path:"",redirectTo:"home",pathMatch:"full"}
]

@NgModule({
  declarations: [
    AdminHomeComponent,
    AdminLessonsComponent,
    EditLessonComponent
  ],
  imports: [
  RouterModule.forChild(routes),
    CommonModule,
    FormsModule
  ]
})
export class AdminModule { }
