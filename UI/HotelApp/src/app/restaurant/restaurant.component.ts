import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-restaurant',
  templateUrl: './restaurant.component.html',
  styleUrls: ['./restaurant.component.css']
})
export class RestaurantComponent implements OnInit{

  readonly APIUrl = "http://localhost:5000/api/Restaurant/";
  restaurante: any[] = new Array(); 
  showDetails: boolean = false;
  
  constructor(private http: HttpClient) {
    this.showDetails = false;
  }

  getAllRestaurante() {
    if (this.showDetails) {
      this.showDetails = false;
    } else {
      this.http.get<any>(this.APIUrl + 'GetRestaurante').subscribe(response => {
    
        if (response && Array.isArray(response.result)) {
          this.restaurante = response.result;
        } else {

          console.error('Răspunsul de la server nu conține un array "result".');
        }
        this.showDetails = true;
      });
    }
  }
  
  deleteAllRestaurante() {
    this.http.delete(this.APIUrl + 'DeleteRestaurante').subscribe(
      (response: any) => {
        console.log(response);
        this.getAllRestaurante();
      },
      (error: any) => {
        console.error(error);
      }
    );
  }

  ngOnInit() {
  }


}
