import { Component, OnInit } from '@angular/core';
import { HttpHomeService } from 'src/app/services/http.home.service';
import { HttpHomeItemsService } from 'src/app/services/http.homeitems.service';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit{

  home: {
    sectionName: string;
    title: string;
    subtitle: string;
    backgroundImage: string;
    startButton: string;
    videoButton: string;
  } = { sectionName: '', title: '', subtitle: '', backgroundImage: '', startButton: '', videoButton: '' };

  homeItems: {title:string, description:string, icon:string, linkUrl:string}[] = [];

  constructor(
    private httpHomeService: HttpHomeService,
    private httpHomeItemsService: HttpHomeItemsService
  ){}


  ngOnInit(): void {
    this.GetHomeData();
    this.GetHomeItemsData();
  }

  GetHomeData(){
    this.httpHomeService.ReadOne(1)
      .subscribe((respuesta: any) =>{
        this.home = respuesta.data;
      })
  }
  GetHomeItemsData(){
    this.httpHomeItemsService.ReadAll()
      .subscribe((respuesta: any) =>{
        this.homeItems = respuesta.data;
      })
  }
  
}
