import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable({
    providedIn: 'root'
})
export class HttpContactService{

    urlBase = "http://localhost:3059/api/contact";

    constructor(private httpClient: HttpClient){}

    ReadOne(id:number){
        let urlWithParams = `${this.urlBase}/${id}`;

        return this.httpClient.get(urlWithParams);
    }
}