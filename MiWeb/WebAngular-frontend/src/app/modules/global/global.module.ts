import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { GlobalMenuComponent } from './components/global-menu/global-menu.component';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { ToastrModule } from 'ngx-toastr';



@NgModule({
  declarations: [
    HeaderComponent,
    FooterComponent,
    GlobalMenuComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    HttpClientModule,
    FormsModule,
    ToastrModule.forRoot({
      closeButton: true,
      progressBar: true,
      enableHtml: true
    })
  ],
  exports: [
    HttpClientModule,
    FormsModule,
    ToastrModule
  ]
})
export class GlobalModule { }
