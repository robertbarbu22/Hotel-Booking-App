import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-client',
  templateUrl: './client.component.html',
  styleUrls: ['./client.component.css']
})
export class ClientComponent implements OnInit {

  readonly APIUrl = "http://localhost:5000/api/Client/";
  clienti: any[] = new Array(); 
  clientId: string = '';
  clientId1: string = '';
  clientNume: string = '';
  clientId2: string = '';
  clientNume1: string = '';
  clientPrenume: string = '';
  clientTelefon: string = '';
  clientEmail: string = '';
  clientRezervari: any = [];
  clientHoteluri: any =[];
  showDetails: boolean = false;
  
  constructor(private http: HttpClient) {
    this.showDetails = false;
  }

  getAllClienti() {
    if (this.showDetails) {
      this.showDetails = false;
    } else {
      this.http.get<any>(this.APIUrl + 'GetAllClients').subscribe(response => {
    
        if (response && Array.isArray(response.result)) {
          this.clienti = response.result;
        } else {

          console.error('Răspunsul de la server nu conține un array "result".');
        }
        this.showDetails = true;
      });
    }
  }

  getClientById() {
    if (this.clientId && this.clientId.trim() !== '') {
      this.http.get<any>(`${this.APIUrl}GetClientById?id=${this.clientId}`).subscribe(response => {
        if (response && response.id) {
            
          this.clienti = [response.result];
          this.showDetails = true;
        } else {
          console.error('Nu s-au găsit date pentru clientul cu ID-ul ' + this.clientId);
        }
      });
    } else {
      console.error('ID-ul clientului nu e valid.');
    }
  }

  getClientByNume() {
    if (this.clientNume && this.clientNume.trim() !== '') {
      this.http.get<any>(`${this.APIUrl}GetClientByNume?nume=${this.clientNume}`).subscribe(response => {
        if (response && response.id) {
          this.clienti = [response.result];
          this.showDetails = true;
        } else {
          console.error('Nu s-au găsit date pentru camera cu numele ' + this.clientNume);
        }
      });
    } else {
      console.error('Nuumele clientului nu este valid.');
    }
  }
  
  deleteAllClienti() {
    this.http.delete(this.APIUrl + 'DeleteAll').subscribe(
      (response: any) => {
        console.log(response);
        this.getAllClienti();
      },
      (error: any) => {
        console.error(error);
      }
    );
  }

  deleteClientById() {
    if (this.clientId1 && this.clientId1.trim() !== ''){
      this.http.delete<any>(`${this.APIUrl}DeleteClient?id=${this.clientId1}`).subscribe(
      (response: any) => {
        console.log(response);
        this.getAllClienti();
      },
      (error: any) => {
        console.error(error);
      }
    );
  }
  }

  createClient() {
    const newClient = {
      id: this.clientId2,
      nume: this.clientNume1,
      prenume: this.clientPrenume,
      telefon: this.clientTelefon,
      email: this.clientEmail,
      rezervari: this.clientRezervari,
      hoteluri: this.clientHoteluri

    };
  
    this.http.post<any>(`${this.APIUrl}CreateClient`, newClient).subscribe(response => {
      if (response && response.id) {
        console.log('Clientul a fost creat cu succes.');
       
        this.getAllClienti();
      } else {
        console.error('A apărut o eroare la crearea clientului.');
      }
    });
  }


  ngOnInit() {
  }

}
