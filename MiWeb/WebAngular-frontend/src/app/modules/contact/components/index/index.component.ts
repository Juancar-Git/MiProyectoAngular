import { Component, OnInit } from '@angular/core';
import { HttpContactService } from 'src/app/services/http.contact.service';
import { HttpContactDataService } from 'src/app/services/http.contactdata.service';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit{

  contact: {
    sectionName: string;
    title: string;
  } = { sectionName: '', title: '' };

  contactData: {
    address: string;
    phone: string;
    email: string;
    mapIframeRrc: string;
  } = { address: '', phone: '', email: '', mapIframeRrc: '' };

  constructor(
    private httpContactService: HttpContactService,
    private httpContactDataService: HttpContactDataService
  ){}

  ngOnInit(): void {
    this.GetContactData();
    this.GetContactDataData();
  }

  GetContactData(){
    this.httpContactService.ReadOne(1)
      .subscribe((respuesta: any) =>{
        this.contact = respuesta.data;
      })
  }

  GetContactDataData(){
    this.httpContactDataService.ReadOne(3)
      .subscribe((respuesta: any) =>{
        this.contactData = respuesta.data;
        console.log(this.contactData)
      })
  }
}
