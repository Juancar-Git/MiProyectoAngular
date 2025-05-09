import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable({
    providedIn: 'root'
})
export class HttpServicesEmployeesService{

    urlBase = "http://localhost:3059/api/servicesemployees";

    constructor(private httpClient: HttpClient){}

    ReadAll(){
        return this.httpClient.get(this.urlBase);
    }

    ReadOne(id:number){
        let urlWithParams = `${this.urlBase}/${id}`;

        return this.httpClient.get(urlWithParams);
    }
}