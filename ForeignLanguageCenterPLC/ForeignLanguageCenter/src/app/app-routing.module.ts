import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HoSoHocVienComponent } from './ho-so-hoc-vien/ho-so-hoc-vien.component';

const routes: Routes = [
  {path: 'hocvien', component: HoSoHocVienComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]

})
export class AppRoutingModule { }
