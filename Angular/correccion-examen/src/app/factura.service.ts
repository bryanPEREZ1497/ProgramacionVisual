import { Injectable } from '@angular/core';
import { Factura } from "./factura";
import { MensajesService } from "./mensajes.service";
import { Observable, of } from 'rxjs';

import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})

export class FacturaService {
  private url = 'api/facturas';  // URL to web api

  constructor(
    private http: HttpClient,
    private mensajesService: MensajesService) { }

  /** Log a HeroService message with the MessageService */
  private log(mensaje: string) {
    this.mensajesService.añadir(`Servicio de mensajes: ${mensaje}`);
  }

  darFacturas(): Observable<Factura[]> {
    return this.http.get<Factura[]>(this.url)
      .pipe(
        tap(_ => this.log('facturas capturadas')),
        catchError(this.handleError<Factura[]>('darFacturas', []))
      );
  }

  /** GET hero by id. Will 404 if id not found */
  darFactura(numerofactura: number): Observable<Factura> {
    const url = `${this.url}/${numerofactura}`;
    return this.http.get<Factura>(url).pipe(
      tap(_ => this.log(`numero de factura=${numerofactura}`)),
      catchError(this.handleError<Factura>(`darFactura numero=${numerofactura}`))
    );
  }

  /**
   * Handle Http operation that failed.
   * Let the app continue.
   * @param operation - name of the operation that failed
   * @param result - optional value to return as the observable result
   */
  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      this.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }

  actualizarFactura(factura: Factura): Observable<any> {
    return this.http.put(this.url, factura, this.httpOptions)
      .pipe(
        tap(_ => this.log(`factura actualizada ${factura.numerofactura}`)),
        catchError(this.handleError<any>('actualizarFactura'))
      )
  }

  nuevaFactura(factura: Factura): Observable<Factura> {
    return this.http.post<Factura>(this.url, factura, this.httpOptions)
      .pipe(
        tap((newFactura: Factura) => this.log(`factura creada`)),
        catchError(this.handleError<Factura>('nuevaFactura'))
      );
  }

  /** DELETE: delete the hero from the server */
  borrarFactura(factura: Factura | number): Observable<Factura> {
    const numerofactura = typeof factura === 'number' ? factura : factura.numerofactura;
    const url = `${this.url}/${numerofactura}`;

    return this.http.delete<Factura>(url, this.httpOptions).pipe(
      tap(_ => this.log(`deleted factura ${numerofactura}`)),
      catchError(this.handleError<Factura>('borrarFactura'))
    );
  }

  /* GET heroes whose name contains search term */
  buscarFacturas(term: string): Observable<Factura[]> {
    if (!term.trim()) {
      // if not search term, return empty hero array.
      return of([]);
    }
    return this.http.get<Factura[]>(`${this.url}/?nombreCliente=${term}`).pipe(
      tap(x => x.length ?
        this.log(`found heroes matching "${term}"`) :
        this.log(`no heroes matching "${term}"`)),
      catchError(this.handleError<Factura[]>('buscarFacturas', []))
    );
  }
}
