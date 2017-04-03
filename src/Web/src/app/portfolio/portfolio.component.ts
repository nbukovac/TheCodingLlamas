import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';

@Component({
  selector: 'app-portfolio',
  templateUrl: './portfolio.component.html',
  styleUrls: ['./portfolio.component.css']
})
export class PortfolioComponent implements OnInit {
projects: Project;
  constructor(private http : Http) {
    http.get('http://localhost:14924/api/projects').subscribe(result => {
          this.projects = result.json();
        });
   }

  ngOnInit() {
  }

}

export class Project {
 Name: string;
 Description: string;
 Year: number;
 PictureUrl: string;
 LiveDemoUrl: string;
 GithubUrl: string;
}
