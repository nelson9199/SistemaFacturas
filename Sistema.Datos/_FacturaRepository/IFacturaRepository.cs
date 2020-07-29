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
        Task<bool> ExisteCodigoFactura(string numFactura);

        Factura ObtenerIdUltimaFactura();

        Task<Factura> ObtenerFacturaPorId(int id);
    }
}
