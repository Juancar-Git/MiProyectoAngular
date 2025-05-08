import { Component, Inject, OnInit } from '@angular/core';
import {
  FormGroup,
  FormBuilder,
  Validators,
  FormControl,
} from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { HttpMessagesService } from 'src/app/services/http.messages.service';
import { finalize } from 'rxjs/operators';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css'],
})
export class FormComponent implements OnInit {
  formGroup!: FormGroup;
  patterEmailValidator: string = '^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$';

  dataType = '';
  isDisabled = false;
  haveData = false;
  item: {
    id: number;
    name: string;
    email: string;
    subject: string;
    messageText: string;
  } = { id: 0, name: '', email: '', subject: '', messageText: '' };

  isNameValid = true;
  isEmailValid = true;
  isSubjectValid = true;
  isMessageValid = true;

  constructor(
    @Inject(MAT_DIALOG_DATA) public data: any,
    public dialogRef: MatDialogRef<FormComponent>,
    private fb: FormBuilder,
    private httpMessageService: HttpMessagesService
  ) {}

  ngOnInit(): void {
    this.initVariables();
  }

  cancel() {
    this.dialogRef.close();
  }

  save() {
    let isValidForm = this.validateItems();
    if (isValidForm) {
      let itemForm = this.fillFormItem();

      if(this.dataType === 'CREATE'){
        this.Create(itemForm);
      }else{
        this.Update(itemForm);
      }
      this.dialogRef.close();
    }
  }

  ReadOne(id: number) {
    this.httpMessageService
      .ReadOne(id)
      .pipe(finalize(() => this.initForm()))
      .subscribe((respuesta: any) => {
        this.item = respuesta.data;
      });
  }

  Create(item: any) {
    this.httpMessageService.Create(item)
    .subscribe((respuesta: any) => {
      console.log(respuesta);
    });
  }

  Update(item: any) {
    this.httpMessageService.Update(item)
    .subscribe((respuesta: any) => {
      console.log(respuesta);
    });
  }

  initVariables() {
    this.dataType = this.data.type;
    this.isDisabled = this.dataType === 'SHOW';
    this.haveData = this.dataType !== 'CREATE';
    if (this.haveData) {
      this.initDefaultForm();
      this.ReadOne(this.data.id);
    } else {
      this.initForm();
    }
  }

  initDefaultForm() {
    this.formGroup = new FormGroup({
      name: new FormControl(),
      email: new FormControl(),
      subject: new FormControl(),
      messageText: new FormControl(),
    });
  }

  initForm() {
    this.formGroup = this.fb.group({
      name: [
        {
          value: this.haveData ? this.item.name : null,
          disabled: this.isDisabled,
        },
        [Validators.required],
      ],
      email: [
        {
          value: this.haveData ? this.item.email : null,
          disabled: this.isDisabled,
        },
        [Validators.required, Validators.pattern(this.patterEmailValidator)],
      ],
      subject: [
        {
          value: this.haveData ? this.item.subject : null,
          disabled: this.isDisabled,
        },
        [Validators.required],
      ],
      messageText: [
        {
          value: this.haveData ? this.item.messageText : null,
          disabled: this.isDisabled,
        },
        [Validators.required],
      ],
    });
  }

  fillFormItem() {
    return {
      id: this.item.id,
      name: this.formGroup.value.name,
      email: this.formGroup.value.email,
      subject: this.formGroup.value.subject,
      messageText: this.formGroup.value.messageText,
      contactId: 3,
    };
  }

  validateItems() {
    this.isNameValid = this.formGroup.controls['name'].status === 'VALID';
    this.isEmailValid = this.formGroup.controls['email'].status === 'VALID';
    this.isSubjectValid = this.formGroup.controls['subject'].status === 'VALID';
    this.isMessageValid =
      this.formGroup.controls['messageText'].status === 'VALID';

    console.log(this.formGroup);

    return (
      this.isNameValid &&
      this.isEmailValid &&
      this.isSubjectValid &&
      this.isMessageValid
    );
  }
}
