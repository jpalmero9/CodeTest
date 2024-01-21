// ---------------------------------------------------
// Demo 1: https://quickapp-pro.azurewebsites.net
// Demo 2: https://quickapp-standard.azurewebsites.net
//
// --> Gun4Hire: contact@ebenmonney.com
// ---------------------------------------------------

import { Component, ViewChild, ElementRef, Input, Output, EventEmitter, HostListener } from '@angular/core';

@Component({
  selector: 'app-search-box',
  templateUrl: './search-box.component.html',
  styleUrls: ['./search-box.component.scss']
})
export class SearchBoxComponent {

  @Input()
  placeholder = 'Search...';

  @Output()
  searchChange = new EventEmitter<string>();

  @ViewChild('searchInput')
  searchInput!: ElementRef;


  onValueChange(value: string) {
    setTimeout(() => this.searchChange.emit(value));
  }

  @HostListener('keydown.escape')
  clear() {
    this.searchInput.nativeElement.value = '';
    this.onValueChange(this.searchInput.nativeElement.value);
  }
}
