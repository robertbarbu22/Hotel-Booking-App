import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-departament',
  templateUrl: './departament.component.html',
  styleUrls: ['./departament.component.css']
})
export class DepartamentComponent implements OnInit {
  readonly APIUrl = "http://localhost:5000/api/Departament/";
  departamente: any[] = new Array(); 
  showDetails: boolean = false;
  
  constructor(private http: HttpClient) {
    this.showDetails = false;
  }

  getAllDepartamente() {
    if (this.showDetails) {
      this.showDetails = false;
    } else {
      this.http.get<any>(this.APIUrl + 'GetDepartamente').subscribe(response => {
    
        if (response && Array.isArray(response.result)) {
          this.departamente = response.result;
        } else {

          console.error('Răspunsul de la server nu conține un array "result".');
        }
        this.showDetails = true;
      });
    }
  }
  
  deleteAllDepartamente() {
    this.http.delete(this.APIUrl + 'DeleteDepartamente').subscribe(
      (response: any) => {
        console.log(response);
        this.getAllDepartamente();
      },
      (error: any) => {
        console.error(error);
      }
    );
  }

  ngOnInit() {
  }

}
