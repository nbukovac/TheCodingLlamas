import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';

@Component({
  selector: 'app-about-us',
  templateUrl: './about-us.component.html',
  styleUrls: ['./about-us.component.css']
})
export class AboutUsComponent implements OnInit {
personsData: Person;

  constructor(private http:Http) {
     http.get('/api/persons').subscribe(result => {
          this.personsData = result.json();
        });
   }

  ngOnInit() {
  }

}

export class Person{
  Id: string;
  FirstName: string;
  LastName: string;
  Year: number;
  College: string;
  LinkedInUrl: string;
  GithubUrl: string;
  Email: string;
  PhoneNumber: string;
  RealTitle: string;
  InternalTitle: string;
  ProfilePicture: string;
}
