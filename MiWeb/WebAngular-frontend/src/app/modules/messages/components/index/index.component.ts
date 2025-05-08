import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { HttpMessagesService } from 'src/app/services/http.messages.service';
import { MatDialog } from '@angular/material/dialog'
import { FormComponent } from '../form/form.component'

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit{

  displayedColumns: string[] = ['Id','Name', 'Email', 'Subject', 'Actions'];
  dataSource: {id:number, name:string, email:string, subject:string}[] = [];

  searchText = "";

  totalQuantity = 0;
  quantityPerPage = 4;
  pageNumber = 0;
  pageNumberList: number[] = [];
  totalPages = 0;

  isPreviousVisible = true;
  isLastVisible = true;

  constructor(
    private httpMessageService: HttpMessagesService,
    private toastr: ToastrService,
    private dialog: MatDialog
  ){}

  ngOnInit(): void {
    this.ReadAll();
  }

  ReadAll(){
    this.httpMessageService.ReadAll(this.quantityPerPage, this.pageNumber, this.searchText)
    .subscribe((respuesta: any) =>{
      this.dataSource = respuesta.data.elemento;
      this.totalQuantity = respuesta.data.totalQuantity
      this.ChangePageVariables();
    })
  }

  Delete(itemId: number){
    let confirmation = confirm("Are you sure you want to delete this item?")

    if(confirmation){
      let ids = [itemId]
      this.httpMessageService.Delete(ids)
      .subscribe((respuesta: any) =>{
        this.toastr.success('Item successfully removed','Confirmation')
        this.ReadAll();
      })
    }
  }


  addMessage(){
    this.openDialog('CREATE', 0);
  }

  showMessage(id: any){
    this.openDialog('SHOW', id);
  }

  editMessage(id: any){
    this.openDialog('UPDATE', id);
  }

  openDialog(type:string, id: any){
    const dialogRef = this.dialog.open(FormComponent, {
      disableClose: true,
      autoFocus: true,
      closeOnNavigation: false,
      position: { top: '30px'},
      data:{
        type: type,
        id: id
      }
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    })
  }

  ChangePageVariables(){
    let aditionalPage = this.totalQuantity%this.quantityPerPage > 0 ? 1 : 0;
    this.totalPages = Math.floor(this.totalQuantity/this.quantityPerPage) + aditionalPage;
    this.pageNumberList = Array.from(Array(this.totalPages).keys())
    this.isPreviousVisible = this.totalPages > 1 && this.pageNumber > this.pageNumberList[0];
    this.isLastVisible = this.totalPages > 1 && this.pageNumber < this.pageNumberList[this.pageNumberList.length-1];
  }

  changePage(currentPageNumber: number){
    this.pageNumber = currentPageNumber;
    this.ReadAll();
  }
}
