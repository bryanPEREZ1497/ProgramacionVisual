import { Producto } from "./producto";

export interface Factura {
    fechaEmision: Date;
    numerofactura: number;
    cedulaRuc: number;
    nombreCliente: string;
    direccion: string;
    telefono: number;
    subtotal: number;
    iva: number;
    total: number;
    productos:Producto[]
    
}
