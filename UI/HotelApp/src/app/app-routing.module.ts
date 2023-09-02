import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AngajatComponent } from './angajat/angajat.component'; 
import { Router } from '@angular/router';
import { CameraComponent } from './camera/camera.component';
import { ClientComponent } from './client/client.component';
import { DepartamentComponent } from './departament/departament.component';
import { HotelComponent } from './hotel/hotel.component';
import { RestaurantComponent } from './restaurant/restaurant.component';
import { RezervareComponent } from './rezervare/rezervare.component';

const routes: Routes = [
  { path: 'angajat', component: AngajatComponent },
  { path: 'camera', component: CameraComponent },
  { path: 'client', component: ClientComponent },
  { path: 'departament', component: DepartamentComponent },
  { path: 'hotel', component: HotelComponent },
  { path: 'restaurant', component: RestaurantComponent },
  { path: 'rezervare', component: RezervareComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
