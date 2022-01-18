import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { productsByNameEP, productsEP } from '../../types/constants';

@Injectable({
  providedIn: 'root',
})
export class ProductsService {
  constructor(private httpClient: HttpClient) {}

  getAllProducts() {
    return this.httpClient.get<IProductDisplay[]>(productsEP);
  }

  getByName(name: string) {
    return this.httpClient.get<IProduct[]>(productsByNameEP(name));
  }
}
