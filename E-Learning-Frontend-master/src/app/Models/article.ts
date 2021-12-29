import { Topic } from "./topic";


export class Article{
  id:number;
  title:string;
  image:string;
  createdAt:Date;
  topics:Topic[];
  content:string;
}
