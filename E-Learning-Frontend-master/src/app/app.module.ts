import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { QuestionsComponent } from './components/questions/questions.component';
import { ErrorComponent } from './components/error/error.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { AnswersComponent } from './components/answers/answers.component';
import { HeaderComponent } from './components/Shared/header/header.component';
import { FooterComponent } from './components/Shared/footer/footer.component';
import { FirstsectionComponent } from './components/Home/firstsection/firstsection.component';
import { MasterpageComponent } from './components/Home/masterpage/masterpage.component';
import { SecondsectionComponent } from './components/Home/secondsection/secondsection.component';
import { ThiredsectionComponent } from './components/Home/thiredsection/thiredsection.component';
import { FourthsectionComponent } from './components/Home/fourthsection/fourthsection.component';
import { SectionfiveComponent } from './components/Home/sectionfive/sectionfive.component';
import { SectionsixComponent } from './components/Home/sectionsix/sectionsix.component';
import { SectionsevenComponent } from './components/Home/sectionseven/sectionseven.component';
import { ExamComponent } from './components/exam/exam.component';
import { LessonComponent } from './components/lesson/lesson.component';
import { CoursedetailesComponent } from './components/coursedetailes/coursedetailes.component';
import { ArticleComponent } from './components/article/article.component';
import {MatProgressBarModule} from '@angular/material/progress-bar';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { IntercepterService } from './components/loader/intercepter.service';
import { QuestionscontComponent } from './components/questionsPool/questionscont/questionscont.component';
import { QuestionfilterComponent } from './components/questionsPool/questionfilter/questionfilter.component';
import { MasterquestionpoolComponent } from './components/questionsPool/masterquestionpool/masterquestionpool.component';
import { MatRadioModule } from '@angular/material/radio';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { ReactiveFormsModule } from '@angular/forms';
import { ArticlecommentComponent } from './components/article/articlecomment/articlecomment.component';
import { RegisterComponent } from './components/register/register.component';
import { LoginComponent } from './components/login/login.component';

import { AllLessonsComponent } from './components/all-lessons/all-lessons.component';


import { AllcoursesComponent } from '../app/components/allcourses/allcourses.component';


import { ProfileComponent } from './components/profile/profile.component';
import { AllArticlesComponent } from './components/all-articles/all-articles.component';

@NgModule({
  declarations: [
    AppComponent,
    QuestionsComponent,
    ErrorComponent,
    AnswersComponent,
    HeaderComponent,
    FooterComponent,
    FirstsectionComponent,
    MasterpageComponent,
    SecondsectionComponent,
    ThiredsectionComponent,
    FourthsectionComponent,
    SectionfiveComponent,
    SectionsixComponent,
    SectionsevenComponent,
    ExamComponent,
    LessonComponent,
    QuestionscontComponent,
    QuestionfilterComponent,
    MasterquestionpoolComponent,
    CoursedetailesComponent,
    ArticleComponent,
    ArticlecommentComponent,
    RegisterComponent,
    LoginComponent,
    AllLessonsComponent,
    AllcoursesComponent,

    ProfileComponent,
    AllLessonsComponent,
    AllcoursesComponent,
    AllArticlesComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    MatProgressBarModule,
    BrowserAnimationsModule,
    MatRadioModule,
    MatAutocompleteModule,
    MatInputModule,
    MatFormFieldModule,
    ReactiveFormsModule,
  ],
  providers: [
    {provide:HTTP_INTERCEPTORS,useClass:IntercepterService,multi:true},
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
