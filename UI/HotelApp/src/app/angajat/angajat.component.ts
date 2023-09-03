import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-angajat',
  templateUrl: './angajat.component.html',
  styleUrls: ['./angajat.component.css']
})
export class AngajatComponent implements OnInit {
  readonly APIUrl = "http://localhost:5000/api/Angajat/";
  angajati: any[] = [];
  showDetails: boolean = false;


  constructor(private http: HttpClient) {
    this.showDetails = false;
   }

  getAllAngajati() {
    if (this.showDetails) {
      this.showDetails = false; 
    } else {
      this.http.get(this.APIUrl + 'GetAllAngajati').subscribe(data => {
        this.angajati = data as any[];
        this.showDetails = true; 
      });
    }
  }

  deleteAllAngajati() {
    this.http.delete(this.APIUrl + 'DeleteAngajati').subscribe(
      (response: any) => {
        console.log(response); 
        this.getAllAngajati(); 
      },
      (error: any) => {
        
        console.error(error); 
      }
    );
  }
  
  
  ngOnInit() {
    
  }
}
