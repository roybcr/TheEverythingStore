import { Component, OnInit } from '@angular/core';
import { of, Subject, Subscription } from 'rxjs';
import { ProductsService } from './services/products/products.service';
import {
  debounceTime,
  distinctUntilChanged,
  share,
  switchMap,
  tap,
} from 'rxjs/operators';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  sub: Subscription = new Subscription();

  products: IProduct[] = [];
  incoming: IProduct[] = [];

  searchSubject: Subject<string> = new Subject();
  searchSource$ = this.searchSubject.asObservable();
  shouldShowIncoming: boolean = false;

  constructor(private readonly productsService: ProductsService) {}

  // On Search event validate the input before sending a request.
  onSearch = (value: string) => {
    if (value.length >= 3) {
      this.searchSubject.next(value.trim());
    } else {
      this.shouldShowIncoming = false;
    }
  };

  typeAhead$ = (value?: string) =>
    this.searchSource$
      .pipe(
        debounceTime(300),
        distinctUntilChanged(),
        switchMap(this.incomingProducts),
        share()
      )
      .pipe(
        tap((result) => {
          this.products = [...this.products, ...this.incoming];
          this.incoming = [...result.reverse().slice(0, 5)];
          if (result.length > 0) {
            this.shouldShowIncoming = true;
          }
        })
      );

  incomingProducts = (query: string) =>
    this.productsService.getByName(query).pipe(
      tap(
        (x) =>
          // Handle new incoming products by filtering out duplicates.
          (this.products = [
            ...this.products,
            ...x.filter(
              (product) =>
                this.products.findIndex((p) => p.sku === product.sku) === -1
            ),
          ])
      )
    );

  getAllProducts() {
    this.sub = this.productsService
      .getAllProducts()
      .subscribe((data: IProductDisplay[]) => {
        this.products = [...data];
      });
  }

  ngOnInit() {
    this.getAllProducts();
    this.typeAhead$().subscribe();
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }
}
