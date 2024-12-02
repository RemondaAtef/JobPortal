import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-add-property',
  templateUrl: './add-property.component.html',
  styleUrls: ['./add-property.component.css']
})

export class AddPropertyComponent implements OnInit {
  @ViewChild('Form') addPropertyForm: NgForm;
  public propertyId: number;
  constructor(
    private route: ActivatedRoute//Router

  ) { }

  ngOnInit() {
    //this.addPropertyForm.controls['Name'].setValue('Default value');
    this.propertyId = this.route.snapshot.params['id'];
  }





  //onBack() {
  //  this.route.navigate(['/']);
  //}

  onSubmit(Form: NgForm) {
    console.log('form submited');
    console.log(this.addPropertyForm);
  }
}
