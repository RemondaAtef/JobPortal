import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { HousingService } from 'src/app/services/housing.service';
import { IProperty } from '../IProperty.Interface';
@Component({
  selector: 'app-property-detail',
  templateUrl: './property-detail.component.html',
  styleUrls: ['./property-detail.component.css']
})

export class PropertyDetailComponent implements OnInit {
  public propertyId: number;
  @Input() property: IProperty;
  constructor(private route: ActivatedRoute,
   private router: Router,
    private housingService: HousingService
  ) { }

  ngOnInit() {
    this.propertyId = this.route.snapshot.params['id'];


  }
}
