import { Component, OnInit } from '@angular/core';
import { Factura } from '../factura';
import { FacturaService } from '../factura.service';
import { MensajesService } from '../mensajes.service';

@Component({
  selector: 'app-factura',
  templateUrl: './factura.component.html',
  styleUrls: ['./factura.component.css']
})
export class FacturaComponent implements OnInit {

  facturas: Factura[] = [];
  facturaSeleccionada: Factura|null=null;

  constructor(private facturaService: FacturaService, private mensajesService:MensajesService) { }

  ngOnInit(): void {
    this.darFacturas();
  }

  darFacturas(): void {
    this.facturaService.darFacturas()
      .subscribe(facturas => this.facturas = facturas)
  }

  onSelect(factura:Factura):void {  
    this.facturaSeleccionada=factura;
    this.mensajesService.añadir("Número de factura seleccionada"+factura.numerofactura);
  }

}
