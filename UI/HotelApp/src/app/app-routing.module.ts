import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AngajatComponent } from './angajat/angajat.component'; 
import { Router } from '@angular/router';
import { CameraComponent } from './camera/camera.component';

const routes: Routes = [
  { path: 'angajat', component: AngajatComponent },
  { path: 'camera', component: CameraComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
