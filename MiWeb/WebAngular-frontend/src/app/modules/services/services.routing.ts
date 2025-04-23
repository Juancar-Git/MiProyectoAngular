import { Routes } from "@angular/router";
import { IndexComponent } from "../services/components/index/index.component";


export const servicesRoutes: Routes = [
    {
        path: 'services/index',
        component: IndexComponent,
        loadChildren: () => import('./services.module').then(m => m.ServicesModule)
    }
]