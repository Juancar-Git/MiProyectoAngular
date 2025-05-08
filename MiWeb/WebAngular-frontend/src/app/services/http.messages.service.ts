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

    ReadOne(id:number){
        let urlWithParams = `${this.urlBase}/${id}`;

        return this.httpClient.get(urlWithParams);
    }

    Create(item: any){
        const option = {
            headers: new HttpHeaders({
                'Content-type': 'application/json'
            })
        };
        return this.httpClient.post(this.urlBase, item, option);   
    }

    Update(item: any){
        let urlWithId = `${this.urlBase}/${item.id}`;

        const option = {
            headers: new HttpHeaders({
                'Content-type': 'application/json'
            })
        };
        return this.httpClient.put(urlWithId, item, option);   
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