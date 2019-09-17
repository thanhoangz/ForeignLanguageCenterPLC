import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HoSoHocVienComponent } from './ho-so-hoc-vien/ho-so-hoc-vien.component';
import { LichocComponent } from './lichoc/lichoc.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {NoopAnimationsModule} from '@angular/platform-browser/animations';
import {MatButtonModule} from '@angular/material/button';
import {MatCheckboxModule} from '@angular/material/checkbox';
import { BaoCaoComponent } from './bao-cao/bao-cao.component';
import { KhoaHocComponent } from './khoa-hoc/khoa-hoc.component';
import { NhanvienComponent } from './nhanvien/nhanvien.component';
import { DanhsachlopComponent } from './danhsachlop/danhsachlop.component';
import { LopComponent } from './danhsachlop/lop/lop.component';
import {MatTabsModule} from '@angular/material/tabs';


@NgModule({
  declarations: [
    AppComponent,
    HoSoHocVienComponent,
    LichocComponent,
    BaoCaoComponent,
    KhoaHocComponent,
    NhanvienComponent,
    DanhsachlopComponent,
    LopComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    NoopAnimationsModule,
    MatButtonModule,
    MatCheckboxModule,
    MatTabsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
