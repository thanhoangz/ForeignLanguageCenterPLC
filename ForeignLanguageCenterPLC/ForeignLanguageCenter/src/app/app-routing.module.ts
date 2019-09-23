
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HoSoHocVienComponent } from './ho-so-hoc-vien/ho-so-hoc-vien.component';
import {LichocComponent} from './lichoc/lichoc.component';
import {KhoaHocComponent} from './khoa-hoc/khoa-hoc.component';
import {NhanvienComponent} from './nhanvien/nhanvien.component';
import {DanhsachlopComponent} from './danhsachlop/danhsachlop.component';
import {AdminManagementComponent} from './admin/admin-management/admin-management.component';
const routes: Routes = [
  {path: 'danhmuc/quanlyhocvien', component: HoSoHocVienComponent},
  {path: 'danhmuc/lichhoc', component: LichocComponent},
  {path: 'danhmuc/khoahoc', component: KhoaHocComponent},
  {path: 'danhmuc/nhanvien', component: NhanvienComponent},
  {path: 'danhmuc/danhsachlop', component: DanhsachlopComponent},
  {path: 'admin', component: AdminManagementComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]

})
export class AppRoutingModule { }
