import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { GlobalMenuComponent } from './components/global-menu/global-menu.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    HeaderComponent,
    FooterComponent,
    GlobalMenuComponent
  ],
  imports: [
    CommonModule,
    RouterModule
  ]
})
export class GlobalModule { }
