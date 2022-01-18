import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-productCard',
  templateUrl: './product-card.component.html',
  styleUrls: ['./product-card.component.css'],
})
export class ProductCardComponent {
  @Input('product') product: IProductDisplay | undefined;

  constructor() {}
}
