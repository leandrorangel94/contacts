import { Injectable } from '@angular/core';
import { ContactDetail } from './contact-detail.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class ContactDetailService {
  constructor(private http: HttpClient) {}

  formData: ContactDetail = new ContactDetail();
  readonly baseURL = 'http://localhost:58320/api/ContactDetail';
  list: ContactDetail[];

  postContactDetail() {
    return this.http.post(this.baseURL, this.formData);
  }

  putContactDetail() {
    return this.http.put(
      `${this.baseURL}/${this.formData.contactDetailId}`,
      this.formData
    );
  }

  deleteContactDetail(id: number) {
    return this.http.delete(`${this.baseURL}/${id}`);
  }

  refreshList() {
    this.http
      .get(this.baseURL)
      .toPromise()
      .then((res) => (this.list = res as ContactDetail[]));
  }
}
