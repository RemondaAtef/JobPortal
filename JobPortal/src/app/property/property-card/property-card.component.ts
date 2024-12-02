import { Component, Input } from "@angular/core";
import { IApplication } from "../IApplication";
import { IProperty } from "../IProperty.Interface";


@Component({
  selector: 'app-property-card',
  templateUrl: 'property-card.component.html',
  styleUrls: ['property-card.component.css']
  }
)
export class propertyCardComponent {
  
  @Input() property: IProperty;
 
}
