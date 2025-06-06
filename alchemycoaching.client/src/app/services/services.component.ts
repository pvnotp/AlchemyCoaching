import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-services',
  imports: [],
  templateUrl: './services.component.html',
  styleUrl: './services.component.scss'
})
export class ServicesComponent implements OnInit{
  
  queryString: string = window.location.search;
  urlParams: URLSearchParams = new URLSearchParams(this.queryString);
  coach: string = this.urlParams.get('coach') ?? "Courtney";

  ngOnInit(){
    document.getElementsByClassName(this.coach.toLowerCase())[0].classList.add("selected");
  }

  selectCoach(name: string) {
    document.getElementsByClassName(this.coach.toLowerCase())[0].classList.remove("selected");
    this.coach = name;
    document.getElementsByClassName(this.coach.toLowerCase())[0].classList.add("selected");
  }

  getCost(coachingPackage: string): number {
    if (coachingPackage == "single session") {
      if (this.coach == "Courtney") {
        return 95;
      }
      else {
        return 75;
      }
    }
    return 0;
  }

}
