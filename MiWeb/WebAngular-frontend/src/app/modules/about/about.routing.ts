import { Routes } from "@angular/router";
import { IndexComponent } from "../about/components/index/index.component";


export const aboutRoutes: Routes = [
    {
        path: 'about/index',
        component: IndexComponent,
        loadChildren: () => import('./about.module').then(m => m.AboutModule)
    }
]