import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";
import { globalRoutes } from "./modules/global/global.routing";
import { homeRoutes } from "./modules/home/home.routing";
import { aboutRoutes } from "./modules/about/about.routing";
import { contactRoutes } from "./modules/contact/contact.routing";
import { messagesRoutes } from "./modules/messages/messages.routing";
import { portfolioRoutes } from "./modules/portfolio/portfolio.routing";
import { servicesRoutes } from "./modules/services/services.routing";



@NgModule({
    imports: [RouterModule.forChild([
        ...globalRoutes,
        ...homeRoutes,
        ...aboutRoutes,
        ...contactRoutes,
        ...messagesRoutes,
        ...portfolioRoutes,
        ...servicesRoutes
    ])],
    exports: [RouterModule]
})
export class RutasModule{}