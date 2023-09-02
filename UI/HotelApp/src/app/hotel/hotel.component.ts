import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-hotel',
  templateUrl: './hotel.component.html',
  styleUrls: ['./hotel.component.css']
})
export class HotelComponent implements OnInit {

  readonly APIUrl = "http://localhost:5000/api/Hotel/";
  hotels: any[] = new Array(); // Definiți un vector (array) pentru camere
  hotelId: string = '';
  hotelId1: string = '';
  hotelNume: string = '';
  showDetails: boolean = false;
  
  constructor(private http: HttpClient) {
    this.showDetails = false;
  }

  getAllHotels() {
    if (this.showDetails) {
      this.showDetails = false;
    } else {
      this.http.get<any>(this.APIUrl + 'GetHotels').subscribe(response => {
    
        if (response && Array.isArray(response.result)) {
          this.hotels = response.result;
        } else {

          console.error('Răspunsul de la server nu conține un array "result".');
        }
        this.showDetails = true;
      });
    }
  }

  getHotelById() {
    if (this.hotelId && this.hotelId.trim() !== '') {
      this.http.get<any>(`${this.APIUrl}GetById?id=${this.hotelId}`).subscribe(response => {
        if (response && response.id) {
            
          this.hotels = [response.result];
          this.showDetails = true;
        } else {
          console.error('Nu s-au găsit date pentru hotelul cu ID-ul ' + this.hotelId);
        }
      });
    } else {
      console.error('ID-ul hotelului nu e valid.');
    }
  }

  getHotelByNume() {
    if (this.hotelNume && this.hotelNume.trim() !== '') {
      this.http.get<any>(`${this.APIUrl}GetByNume?nume=${this.hotelNume}`).subscribe(response => {
        if (response && response.id) {
          // Afișați datele camerei când se găsesc
          this.hotels = [response.result];
          this.showDetails = true;
        } else {
          console.error('Nu s-au găsit date pentru hotelul cu numele ' + this.hotelNume);
        }
      });
    } else {
      console.error('Nuumele hotelului nu este valid.');
    }
  }
  
  deleteAllHotels() {
    this.http.delete(this.APIUrl + 'DeleteHotels').subscribe(
      (response: any) => {
        console.log(response);
        this.getAllHotels();
      },
      (error: any) => {
        console.error(error);
      }
    );
  }

  deleteHotelById() {
    if (this.hotelId1 && this.hotelId1.trim() !== ''){
      this.http.delete<any>(`${this.APIUrl}DeleteHotel?id=${this.hotelId1}`).subscribe(
      (response: any) => {
        console.log(response);
        this.getAllHotels();
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
