import { Component, OnInit } from '@angular/core';
import { HttpPortfolioService } from 'src/app/services/http.portfolio.service';
import { HttpPortfolioItemsService } from 'src/app/services/http.portfolioitems.service';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit{

  portfolio: {
    sectionName: string;
    title: string;
  } = { sectionName: '', title: '' };

  portfolioItems: {title:string, description:string, pictureUrl:string}[] = [];

  constructor(
    private httpPortfolioService: HttpPortfolioService,
    private httpPortfolioItemsService: HttpPortfolioItemsService
  ){}

  ngOnInit(): void {
    this.GetPortfolioData();
    this.GetPortfolioItemsData();
  }

  GetPortfolioData(){
    this.httpPortfolioService.ReadOne(1)
      .subscribe((respuesta: any) =>{
        this.portfolio = respuesta.data;
      })
  }

  GetPortfolioItemsData(){
    this.httpPortfolioItemsService.ReadAll()
      .subscribe((respuesta: any) =>{
        this.portfolioItems = respuesta.data;
      })
  }

}
