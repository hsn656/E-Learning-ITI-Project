import { Comment } from './comment';

export class Post {
  id?: number;
  content: string;
  views: number;
  createdAt: string;
  userId: string;
  userName: string;
  image: string;
  postLikes: number;
  commentsCount: number;
  comments: Comment[];
  postLikesArr: string[];
  postDisLikesArr: string[];
}

