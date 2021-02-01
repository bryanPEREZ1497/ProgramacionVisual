import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { Factura } from '../factura';
import { FacturaService } from "../factura.service";
import { Producto } from '../producto';

@Component({
  selector: 'app-detalle-factura',
  templateUrl: './detalle-factura.component.html',
  styleUrls: ['./detalle-factura.component.css']
})

export class DetalleFacturaComponent implements OnInit {
  //@Input() factura: Factura | null = null;
  factura: Factura;
  productos: Producto[];

  constructor(
    private route: ActivatedRoute,
    private facturaService: FacturaService,
    private location: Location
  ) { }

  ngOnInit(): void {
    this.darFactura();
  }

  darFactura(): void {
    const numerofactura = +this.route.snapshot.paramMap.get('numerofactura');
    this.facturaService.darFactura(numerofactura)
      .subscribe(factura => {
        this.factura = factura;
        this.productos = factura.productos;
      });
  }
  regresar(): void {
    this.location.back();
  }

  guardar(): void {
    this.facturaService.actualizarFactura(this.factura)
      .subscribe(()=>this.regresar());
  }
}
