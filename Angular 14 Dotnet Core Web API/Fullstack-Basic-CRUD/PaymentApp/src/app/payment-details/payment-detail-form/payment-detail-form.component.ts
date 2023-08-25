import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { PaymentDetail } from 'src/app/shared/payment-detail.model';
import { PaymentDetailService } from 'src/app/shared/payment-detail.service';

@Component({
  selector: 'app-payment-detail-form',
  templateUrl: './payment-detail-form.component.html',
  styles: [],
})
export class PaymentDetailFormComponent implements OnInit {
  constructor(
    public service: PaymentDetailService,
    private toastr: ToastrService
  ) {}

  ngOnInit(): void {}

  onSubmit(form: NgForm) {
    this.service.formSubmitted = true;
    if (form.valid) {
      // On basis of Primary key paymentdetailID we will determine whether it is an Insert/Update opertion.
      // When paymentdetailID = 0, it is a fresh form meaning an insert operation needs to be performed.
      if (this.service.formData.paymentDetailId == 0) {
        this.insertRecord(form);
      } else {
        this.updateRecord(form);
      }
    }
  }

  insertRecord(form: NgForm) {
    // Below code returns an observer, so subscribe to it.
    this.service.postPaymentDetail().subscribe({
      next: (res) => {
        // Update the Payment detail List UI and reset the form
        this.service.list = res as PaymentDetail[];
        this.service.resetForm(form);

        this.toastr.success('Inserted successfully', 'Payment Detail Register');
      },
      error: (err) => {
        console.log(err);
      },
    });
  }

  updateRecord(form: NgForm) {
    this.service.putPaymentDetail().subscribe({
      next: (res) => {
        this.service.list = res as PaymentDetail[];
        this.service.resetForm(form);

        this.toastr.info('Updated successfully', 'Payment Detail Register');
      },
      error: (err) => {
        console.log(err);
      },
    });
  }
}
