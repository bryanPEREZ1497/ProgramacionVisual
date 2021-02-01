import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { FacturaComponent } from './factura/factura.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { DetalleFacturaComponent } from "./detalle-factura/detalle-factura.component";

const routes: Routes = [
  { path: 'facturas', component: FacturaComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'detalle/:numerofactura', component: DetalleFacturaComponent },
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }