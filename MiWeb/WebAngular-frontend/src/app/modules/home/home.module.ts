import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IndezComponent } from './components/indez/indez.component';
import { IndexComponent } from './components/index/index.component';



@NgModule({
  declarations: [
    IndezComponent,
    IndexComponent
  ],
  imports: [
    CommonModule
  ]
})
export class HomeModule { }
