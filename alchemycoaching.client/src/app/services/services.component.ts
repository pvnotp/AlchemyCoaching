import { NgClass } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-services',
  imports: [NgClass],
  templateUrl: './services.component.html',
  styleUrl: './services.component.scss'
})
export class ServicesComponent{
  
  queryString: string = window.location.search;
  urlParams: URLSearchParams = new URLSearchParams(this.queryString);
  coach: string = this.urlParams.get('coach') ?? "Courtney";

  selectCoach(name: string) {
    if (name) {
      this.coach = name;
    }
  }

  //TODO: use this only for logged in clients
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
