import { Component, OnInit } from '@angular/core';
import { HttpAboutService } from 'src/app/services/http.about.service';
import { HttpAboutItemsService } from 'src/app/services/http.aboutitems.service';
import { HttpAboutStatisticsService } from 'src/app/services/http.aboutstatistics.service';
//import { HttpAboutSponsorsService } from 'src/app/services/http.aboutsponsors.service';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit{

  about: {
    sectionName: string;
    title: string;
    mainSubtitle: string;
    secondarySubtitle: string;
    description: string;
    mainImagePath: string;
  } = { sectionName: '', title: '', mainSubtitle: '', secondarySubtitle: '', description: '', mainImagePath: '' };

  aboutItems: {title:string, description:string, icon:string}[] = [];

  aboutStatistics: {name:string, quantity:string, icon:string}[] = [];

  constructor(
    //Se puede hacer todo desde un servicio, pero no tengo claro que es lo mas correcto.
    private httpAboutService: HttpAboutService,
    private httpAboutIttemsService: HttpAboutItemsService,
    private httpAboutStatisticsService: HttpAboutStatisticsService

    //Para ampliación
    //private httpAboutSponsorsService: HttpAboutSponsorsService
  ){
    
  }
  ngOnInit(): void {
    this.GetAboutData();
    this.GetAboutItemsData();
    this.GetAboutStatisticsData()
  }

  GetAboutData(){
    this.httpAboutService.ReadOne(1)
    .subscribe((respuesta: any) =>{
      this.about = respuesta.data;
    })
  }

  GetAboutItemsData(){
    this.httpAboutIttemsService.ReadAll()
    .subscribe((respuesta: any) =>{
      this.aboutItems = respuesta.data;
    })
  }

  GetAboutStatisticsData(){
    this.httpAboutStatisticsService.ReadAll()
    .subscribe((respuesta: any) =>{
      this.aboutStatistics = respuesta.data;
      console.log(this.aboutStatistics);
    })
  }
}
