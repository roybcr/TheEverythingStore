import { Component, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-searchbox',
  templateUrl: './searchbox.component.html',
  styleUrls: ['./searchbox.component.css'],
})
export class SearchboxComponent {
  @Output() onSearchEvent: EventEmitter<string> = new EventEmitter<string>();

  onChange(value: string) {
    this.onSearchEvent.emit(value);
  }
}
