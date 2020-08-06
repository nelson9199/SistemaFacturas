using Sistema.Datos.Services;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos.FacturaRepository
{
    public interface IFacturaRepository<T> : ICrud<T>
    {
        Task<bool> ExisteNumeroFactura(string numFactura, int idCliente);

        Factura ObtenerIdUltimaFactura();

        Task<Factura> ObtenerFacturaPorId(int id);
    }
}
