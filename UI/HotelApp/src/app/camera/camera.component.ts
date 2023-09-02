import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-camera',
  templateUrl: './camera.component.html',
  styleUrls: ['./camera.component.css']
})
export class CameraComponent implements OnInit {

  readonly APIUrl = "http://localhost:5000/api/Camera/";
  camere: any[] = new Array(); // Definiți un vector (array) pentru camere
  cameraId: string = '';
  showDetails: boolean = false;
  
  constructor(private http: HttpClient) {
    this.showDetails = false;
  }

  getAllCamere() {
    if (this.showDetails) {
      this.showDetails = false;
    } else {
      this.http.get<any>(this.APIUrl + 'GetAllCamere').subscribe(response => {
    
        if (response && Array.isArray(response.result)) {
          this.camere = response.result;
        } else {

          console.error('Răspunsul de la server nu conține un array "result".');
        }
        this.showDetails = true;
      });
    }
  }

  getCameraById() {
    if (this.cameraId && this.cameraId.trim() !== '') {
      this.http.get<any>(`${this.APIUrl}GetCameraById/${this.cameraId}`).subscribe(response => {
        if (response && response.id) {
          // Afișați datele camerei când se găsesc
          this.camere = [response];
          this.showDetails = true;
        } else {
          console.error('Nu s-au găsit date pentru camera cu ID-ul ' + this.cameraId);
        }
      });
    } else {
      console.error('ID-ul camerei nu este valid.');
    }
  }
  
  deleteAllCamere() {
    this.http.delete(this.APIUrl + 'DeleteCamere').subscribe(
      (response: any) => {
        console.log(response);
        this.getAllCamere();
      },
      (error: any) => {
        console.error(error);
      }
    );
  }

  ngOnInit() {
  }
}
