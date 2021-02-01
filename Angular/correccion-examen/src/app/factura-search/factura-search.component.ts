import { Component, OnInit } from '@angular/core';
import { Observable, Subject } from 'rxjs';
import {
  debounceTime, distinctUntilChanged, switchMap
} from 'rxjs/operators';
import { Factura } from "../factura";
import { FacturaService } from "../factura.service";

@Component({
  selector: 'app-factura-search',
  templateUrl: './factura-search.component.html',
  styleUrls: ['./factura-search.component.css']
})

export class FacturaSearchComponent implements OnInit {

  facturas$: Observable<Factura[]>;
  private searchTerms = new Subject<string>();

  constructor(private facturaService: FacturaService) { }

  // Push a search term into the observable stream.
  buscar(term: string): void {
    this.searchTerms.next(term);
  }

  ngOnInit(): void {
    this.facturas$ = this.searchTerms.pipe(
      // wait 300ms after each keystroke before considering the term
      debounceTime(300),

      // ignore new term if same as previous term
      distinctUntilChanged(),

      // switch to new search observable each time the term changes
      switchMap((term: string) => this.facturaService.buscarFacturas(term)),
    );
  }

}
