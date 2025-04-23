import { Routes } from "@angular/router";
import { IndexComponent } from "../portfolio/components/index/index.component";


export const portfolioRoutes: Routes = [
    {
        path: 'portfolio/index',
        component: IndexComponent,
        loadChildren: () => import('./portfolio.module').then(m => m.PortfolioModule)
    }
]