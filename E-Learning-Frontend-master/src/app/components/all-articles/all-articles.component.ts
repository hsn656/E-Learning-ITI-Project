import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Article } from 'src/app/Models/article';
import { ArticleService } from 'src/services/article.service';

@Component({
  selector: 'app-all-articles',
  templateUrl: './all-articles.component.html',
  styleUrls: ['./all-articles.component.css']
})
export class AllArticlesComponent implements OnInit {

  Articles:any;
  CopyArticles:any;
  constructor(private ArtService:ArticleService,private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.ArtService.getAllArticle().subscribe(
      (res)=>{
        this.Articles=res as Article[];
        this.CopyArticles=res as Article[]},
      (err)=>{console.log(err)}
    )
  }

  ReBind(e: any): void {
    if (e.target.value !== '') {
      let newData = this.CopyArticles.filter((art:Article) => {
        return art.title.includes(e.target.value);
      });
      this.CopyArticles = newData;
    } else {
      this.CopyArticles = this.Articles;
    }
  }
}
