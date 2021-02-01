import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { FacturaComponent } from './factura/factura.component';
import { MensajesComponent } from './mensajes/mensajes.component';
import { DetalleFacturaComponent } from './detalle-factura/detalle-factura.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { FacturaSearchComponent } from './factura-search/factura-search.component';

import { HttpClientModule } from '@angular/common/http';
import { HttpClientInMemoryWebApiModule } from 'angular-in-memory-web-api';
import { InMemoryDataService } from './in-memory-data.service';



@NgModule({
  declarations: [
    AppComponent,
    FacturaComponent,
    MensajesComponent,
    DetalleFacturaComponent,
    DashboardComponent,
    FacturaSearchComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule,
    HttpClientInMemoryWebApiModule.forRoot(
      InMemoryDataService, { dataEncapsulation: false }
    )
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
