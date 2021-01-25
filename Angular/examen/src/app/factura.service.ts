import { Injectable } from '@angular/core';
import { FACTURAS } from "./facturas-mock";
import { Factura } from "./factura";
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FacturaService {

  constructor() { }
  
  public darFacturas() : Observable<Factura[]> {
    return of(FACTURAS);
  }
  
}
