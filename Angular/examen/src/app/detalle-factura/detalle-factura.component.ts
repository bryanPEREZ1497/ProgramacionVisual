import { Component, OnInit } from '@angular/core';
import { Factura } from '../factura';

@Component({
  selector: 'app-detalle-factura',
  templateUrl: './detalle-factura.component.html',
  styleUrls: ['./detalle-factura.component.css']
})
export class DetalleFacturaComponent implements OnInit {
  factura:Factura|null=null;
  constructor() { }

  ngOnInit(): void {
  }

}
