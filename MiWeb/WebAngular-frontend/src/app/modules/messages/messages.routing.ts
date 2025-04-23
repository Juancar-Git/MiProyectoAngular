import { Routes } from "@angular/router";
import { IndexComponent } from "../messages/components/index/index.component";


export const messagesRoutes: Routes = [
    {
        path: 'messages/index',
        component: IndexComponent,
        loadChildren: () => import('./messages.module').then(m => m.MessagesModule)
    }
]