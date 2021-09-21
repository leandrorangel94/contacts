import { ContactDetailService } from './../../shared/contact-detail.service';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ContactDetail } from 'src/app/shared/contact-detail.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-contact-detail-form',
  templateUrl: './contact-detail-form.component.html',
  styles: [],
})
export class ContactDetailFormComponent implements OnInit {
  constructor(
    public service: ContactDetailService,
    private toastr: ToastrService
  ) {}

  ngOnInit(): void {}

  onSubmit(form: NgForm) {
    if (this.service.formData.contactDetailId == 0) {
      this.insertRecord(form);
      this.service.refreshList();
    } else this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postContactDetail().subscribe(
      (res) => {
        this.resetForm(form);
        this.service.refreshList();
        this.toastr.success(
          'Submitted successfully',
          'Contact Detail Register'
        );
      },
      (err) => {
        console.log(err);
      }
    );
  }

  updateRecord(form: NgForm) {
    this.service.putContactDetail().subscribe(
      (res) => {
        this.resetForm(form);
        this.service.refreshList();
        this.toastr.info('Updated successfully', 'Contact Detail Register');
      },
      (err) => {
        console.log(err);
      }
    );
  }

  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new ContactDetail();
  }
}
