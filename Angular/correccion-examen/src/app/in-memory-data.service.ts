import { Injectable } from '@angular/core';
import { InMemoryDbService } from 'angular-in-memory-web-api';
import { Factura } from './factura';

@Injectable({
  providedIn: 'root',
})

export class InMemoryDataService implements InMemoryDbService {
  createDb() {
    const facturas = [
      {
        fechaEmision: new Date(2029, 3, 2),
        numerofactura: 1,
        cedulaRuc: 1724034184,
        nombreCliente: 'bryan',
        direccion: 'solanda',
        telefono: 2689919,
        subtotal: 33,
        iva: 12,
        total: 233,
        productos: [
          {
            cantidad: 1,
            nombreProducto: "bombom",
            precio: 50,
            valor: 50
          },
          {
            cantidad: 2,
            nombreProducto: "chupete",
            precio: 50,
            valor: 100
          },
          {
            cantidad: 3,
            nombreProducto: "galletas",
            precio: 50,
            valor: 150
          },
          {
            cantidad: 10,
            nombreProducto: "juguetes",
            precio: 50,
            valor: 500
          }

        ]
      },
      {
        fechaEmision: new Date(2019, 3, 2),
        numerofactura: 2,
        cedulaRuc: 17240384,
        nombreCliente: 'banban',
        direccion: 'espacial',
        telefono: 26899193434,
        subtotal: 33334,
        iva: 1234,
        total: 233343,
        productos: [
          {
            cantidad: 1,
            nombreProducto: "bombom",
            precio: 50,
            valor: 50
          },
          {
            cantidad: 2,
            nombreProducto: "chupete",
            precio: 50,
            valor: 100
          },
          {
            cantidad: 3,
            nombreProducto: "galletas",
            precio: 50,
            valor: 150
          },
          {
            cantidad: 10,
            nombreProducto: "juguetes",
            precio: 50,
            valor: 500
          }

        ]
      },
      {
        fechaEmision: new Date(2055, 3, 2),
        numerofactura: 3,
        cedulaRuc: 17240233234184,
        nombreCliente: 'andy',
        direccion: 'eeuu',
        telefono: 26899195656,
        subtotal: 344,
        iva: 1244,
        total: 2333333,
        productos: [
          {
            cantidad: 1,
            nombreProducto: "bombom",
            precio: 50,
            valor: 50
          },
          {
            cantidad: 2,
            nombreProducto: "chupete",
            precio: 50,
            valor: 100
          },
          {
            cantidad: 3,
            nombreProducto: "galletas",
            precio: 50,
            valor: 150
          },
          {
            cantidad: 10,
            nombreProducto: "juguetes",
            precio: 50,
            valor: 500
          }

        ]
      }
    ];
    return { facturas };
  }


  // Overrides the genId method to ensure that a hero always has an id.
  // If the heroes array is empty,
  // the method below returns the initial number (11).
  // if the heroes array is not empty, the method below returns the highest
  // hero id + 1.
  genId(facturas: Factura[]): number {
    return facturas.length > 0 ? Math.max(...facturas.map(factura => factura.numerofactura)) + 1 : 4;
  }
}
