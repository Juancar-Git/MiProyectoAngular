import { HttpClient, HttpHeaders, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable({
    providedIn: 'root'
})
export class HttpMessagesService{

    urlBase = "http://localhost:3059/api/contactmessages";

    constructor(private httpClient: HttpClient){}

    ReadAll(quantity:number, page: number, searchText:string){
        let urlWithParams = `${this.urlBase}?quantity=${quantity}&page=${page}&searchText=${searchText}`;

        return this.httpClient.get(urlWithParams);
    }

    Delete(ids: number[]){
        const option = {
            headers: new HttpHeaders({
                'Content-type': 'application/json'
            }),
            body: ids
        }
        return this.httpClient.delete(this.urlBase, option)   
    }
}