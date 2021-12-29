import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ArticleService } from 'src/services/article.service';

@Component({
  selector: 'app-sectionsix',
  templateUrl: './sectionsix.component.html',
  styleUrls: ['./sectionsix.component.css']
})
export class SectionsixComponent implements OnInit {
  articles:any;
  constructor(private articleservice:ArticleService,private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.articleservice.getSomeArticles().subscribe(
      (res)=>{this.articles=res;},
      (err)=>{console.log(err)}
    )
  }

}
