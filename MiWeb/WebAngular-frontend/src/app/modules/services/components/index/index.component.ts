import { Component, OnInit } from '@angular/core';
import { HttpServicesService } from 'src/app/services/http.services.service';
import { HttpServicesEmployeesService } from 'src/app/services/http.servicesemployees.service';
import { HttpServicesItemsService } from 'src/app/services/http.servicesitems.service';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit{

  services: {
    sectionName: string;
    title: string;
  } = { sectionName: '', title: '' };

  servicesItems: {title:string, description:string, icon:string, linkUrl:string}[] = [];

  constructor(
    private httpServicesService: HttpServicesService,
    private httpServicesItemsService: HttpServicesItemsService
    //Agregar esta función al amplificar el módulo
    //private httpServicesEmployees: HttpServicesEmployeesService
  ){}

  ngOnInit(): void {
    this.GetServicesData();
    this.GetServicesItemsData();
  }

  GetServicesData(){
    this.httpServicesService.ReadOne(1)
      .subscribe((respuesta: any) =>{
        this.services = respuesta.data;
      })
  }

  GetServicesItemsData(){
    this.httpServicesItemsService.ReadAll()
      .subscribe((respuesta: any) =>{
        this.servicesItems = respuesta.data;
      })
  }

}
