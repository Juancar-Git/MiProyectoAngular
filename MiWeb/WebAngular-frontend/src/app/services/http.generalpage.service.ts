import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable({
    providedIn: 'root'
})
export class HttpGeneralPageService{

    urlBase = "http://localhost:3059/api/generalpage";

    constructor(private httpClient: HttpClient){}

    ReadOne(id:number){
        let urlWithParams = `${this.urlBase}/${id}`;

        return this.httpClient.get(urlWithParams);
    }
}