import { Component, OnInit } from '@angular/core';
import { HttpGeneralPageService } from 'src/app/services/http.generalpage.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit{
  
  title: string = '';
  tabList: string[] = ["About","Services","Portfolio","Contact","Messages"]
  linkList: string[] = ["about/index","services/index","portfolio/index","contact/index","messages/index"]

  constructor(
    private httpGeneralPageService: HttpGeneralPageService
  ){}

  ngOnInit(): void {
    this.GetGeneralPageData();
  }

  GetGeneralPageData(){
    this.httpGeneralPageService.ReadOne(1)
      .subscribe((respuesta: any) =>{
        this.title = respuesta.data.title;
      })
  }
}
