
import { Question } from './question';

export class Exam {
  id:number;
  name:string;
  courseId:number;
  questions:Question[]
}
