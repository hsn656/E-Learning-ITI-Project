
import { Lesson } from 'src/app/Models/lesson';
import { Question } from './question';

export class Topic{
id:number;
title:string;
yearNo?:number;
unitNo?:number;
lesonNo?:number;
lessons?:Lesson[];
questions?:Question;
}

export class TopicView{
  id:number;
  title:string;
}
