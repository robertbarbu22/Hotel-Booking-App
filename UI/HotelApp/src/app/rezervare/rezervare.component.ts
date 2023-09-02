import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-rezervare',
  templateUrl: './rezervare.component.html',
  styleUrls: ['./rezervare.component.css']
})
export class RezervareComponent implements OnInit {

  readonly APIUrl = "http://localhost:5000/api/Rezervare/";
  rezervari: any[] = new Array(); // Definiți un vector (array) pentru camere
  rezervareId: string = '';
  rezervareId1: string = '';
  showDetails: boolean = false;
  
  constructor(private http: HttpClient) {
    this.showDetails = false;
  }

  getAllRezervari() {
    if (this.showDetails) {
      this.showDetails = false;
    } else {
      this.http.get<any>(this.APIUrl + 'GetRezervari').subscribe(response => {
    
        if (response && Array.isArray(response.result)) {
          this.rezervari = response.result;
        } else {

          console.error('Răspunsul de la server nu conține un array "result".');
        }
        this.showDetails = true;
      });
    }
  }

  getRezervareById() {
    if (this.rezervareId && this.rezervareId.trim() !== '') {
      this.http.get<any>(`${this.APIUrl}GetRezervareById?id=${this.rezervareId}`).subscribe(response => {
        if (response && response.id) {
            
          this.rezervari = [response.result];
          this.showDetails = true;
        } else {
          console.error('Nu s-au găsit date pentru rezervarea cu ID-ul ' + this.rezervareId);
        }
      });
    } else {
      console.error('ID-ul rezervarii nu e valid.');
    }
  }
  
  deleteAllRezervari() {
    this.http.delete(this.APIUrl + 'DeleteRezervari').subscribe(
      (response: any) => {
        console.log(response);
        this.getAllRezervari();
      },
      (error: any) => {
        console.error(error);
      }
    );
  }

  deleteRezervareById() {
    if (this.rezervareId1 && this.rezervareId1.trim() !== ''){
      this.http.delete<any>(`${this.APIUrl}DeleteRezervare?id=${this.rezervareId1}`).subscribe(
      (response: any) => {
        console.log(response);
        this.getAllRezervari();
      },
      (error: any) => {
        console.error(error);
      }
    );
  }
  }


  ngOnInit() {
  }

}

