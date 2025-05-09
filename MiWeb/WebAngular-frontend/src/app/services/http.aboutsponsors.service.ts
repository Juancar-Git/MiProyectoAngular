import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable({
    providedIn: 'root'
})
export class HttpAboutSponsorsService{
    urlBase = "http://localhost:3059/api/aboutsponsors";

    constructor(private httpClient: HttpClient){}

    ReadAll(){
        return this.httpClient.get(this.urlBase);
    }

    ReadOne(id:number){
        let urlWithParams = `${this.urlBase}/${id}`;

        return this.httpClient.get(urlWithParams);
    }
}