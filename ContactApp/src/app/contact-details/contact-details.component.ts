import { ToastrService } from 'ngx-toastr';
import { ContactDetailService } from './../shared/contact-detail.service';
import { Component, OnInit } from '@angular/core';
import { ContactDetail } from '../shared/contact-detail.model';

@Component({
  selector: 'app-contact-details',
  templateUrl: './contact-details.component.html',
  styles: [],
})
export class ContactDetailsComponent implements OnInit {
  constructor(
    public service: ContactDetailService,
    private toastr: ToastrService
  ) {}

  ngOnInit(): void {
    this.service.refreshList();
  }

  populateForm(selectedRecord: ContactDetail) {
    this.service.formData = Object.assign({}, selectedRecord);
  }

  onDelete(id: number) {
    if (confirm('Tem certeza que deseja remover este contato?')) {
      this.service.deleteContactDetail(id).subscribe(
        (res) => {
          this.service.refreshList();
          this.toastr.error('Delete successfully', 'Contact Detail Register');
        },
        (err) => {
          console.log(err);
        }
      );
    }
  }
}
