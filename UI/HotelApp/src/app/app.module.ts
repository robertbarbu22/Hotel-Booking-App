import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { AngajatComponent } from './angajat/angajat.component';
import { CameraComponent } from './camera/camera.component'; 
import { FormsModule } from '@angular/forms';
import { ClientComponent } from './client/client.component';
import { DepartamentComponent } from './departament/departament.component';
import { HotelComponent } from './hotel/hotel.component';
import { RestaurantComponent } from './restaurant/restaurant.component';
import { RezervareComponent } from './rezervare/rezervare.component';

@NgModule({
  declarations: [
    AppComponent,
    AngajatComponent,
    CameraComponent,
    ClientComponent,
    DepartamentComponent,
    HotelComponent,
    RestaurantComponent,
    RezervareComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule 
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
