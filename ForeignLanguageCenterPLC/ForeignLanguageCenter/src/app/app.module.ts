import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HoSoHocVienComponent } from './ho-so-hoc-vien/ho-so-hoc-vien.component';

@NgModule({
  declarations: [
    AppComponent,
    HoSoHocVienComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
