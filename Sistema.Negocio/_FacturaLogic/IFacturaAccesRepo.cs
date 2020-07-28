using Sistema.Entidades;
using Sistema.Negocio.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio.FacturaLogic
{
    public interface IFacturaAccesRepo<T> : ICrd<T>
    {
        Task<string> Actualizar(T objActualizar, string numFacAnt);

        Factura ObtenerIdUltimaFactura();
    }
}
