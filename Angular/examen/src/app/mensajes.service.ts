import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MensajesService {

  mensajes: string[]=[];

  añadir(mensaje: string){
    this.mensajes.push(mensaje);
  }

  borrar(){
    this.mensajes = [];
  }
}
