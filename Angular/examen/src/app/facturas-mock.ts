import { Factura } from './factura';

export const FACTURAS: Factura[] = [
    {
        fechaEmision: new Date(2029,3,2),
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
            }

        ]
    }

];




