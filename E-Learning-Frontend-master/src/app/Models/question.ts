import { Option } from './option';

export class Question {
  id:number;
  content:string;
  topicId:number[];
  options:Option[];
}
