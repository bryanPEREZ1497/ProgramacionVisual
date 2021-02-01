import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { Factura } from '../factura';
import { FacturaService } from '../factura.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})

export class DashboardComponent implements OnInit {
  facturas: Factura[] = [];

  constructor(private facturaService: FacturaService) { }

  ngOnInit(): void {
    this.darFacturas();
  }
  darFacturas(): void {
    this.facturaService.darFacturas()
      .subscribe(facturas => this.facturas = facturas)
  }

}
