import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GlobalMenuComponent } from './modules/global/components/global-menu/global-menu.component';

const routes: Routes = [
  {path: '',
  component: GlobalMenuComponent,
  loadChildren: () => import('./rutas.module').then(m => m.RutasModule)

}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
