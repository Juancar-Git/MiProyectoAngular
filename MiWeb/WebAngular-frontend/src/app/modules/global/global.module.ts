import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { GlobalMenuComponent } from './components/global-menu/global-menu.component';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ToastrModule } from 'ngx-toastr';
import { MatDialogModule } from '@angular/material/dialog'




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
    ReactiveFormsModule,
    ToastrModule.forRoot({
      closeButton: true,
      progressBar: true,
      enableHtml: true
    }),
    MatDialogModule
  ],
  exports: [
    HttpClientModule,
    FormsModule,
    ToastrModule,
    MatDialogModule,
    ReactiveFormsModule
  ]
})
export class GlobalModule { }
