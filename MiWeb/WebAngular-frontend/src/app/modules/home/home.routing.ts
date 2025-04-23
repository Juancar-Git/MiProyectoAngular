import { Routes } from "@angular/router";
import { IndexComponent } from "../home/components/index/index.component";


export const homeRoutes: Routes = [
    {
        path: 'home/index',
        component: IndexComponent,
        loadChildren: () => import('./home.module').then(m => m.HomeModule)
    }
]