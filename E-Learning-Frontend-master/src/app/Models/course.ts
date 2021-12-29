import { Exam } from 'src/app/Models/exam';
import { Lesson } from 'src/app/Models/lesson';

export class Course{
  id:number;
  description:string;
  image:string;
  name:string;
  order:number
  createdAt:Date;
  exam:Exam;
  lessons:Lesson[];
}
