import { Component, Inject, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog'

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit{

  formGroup!: FormGroup;
  patterEmailValidator: string = "^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$";

  constructor(
    @Inject(MAT_DIALOG_DATA) public data: any,
    public dialogRef: MatDialogRef<FormComponent>,
    private fb: FormBuilder
  ){}

  ngOnInit(): void{
    this.initForm();
  }

  cancelar(){
    this.dialogRef.close();
  }

  guardar(){
    
  }
  
  initForm(){
    this.formGroup = this.fb.group({
      name: [{value: null, disabled: false}, [Validators.required]],
      email: [{value: null, disabled: false}, [Validators.required, Validators.pattern(this.patterEmailValidator)]],
      subject: [{value: null, disabled: false}, [Validators.required]],
      messageText: [{value: null, disabled: false}, [Validators.required]]
    })
  }
}
