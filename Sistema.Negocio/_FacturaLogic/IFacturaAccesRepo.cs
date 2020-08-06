using Sistema.Entidades;
using Sistema.Negocio.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio.FacturaLogic
{
    public interface IFacturaAccesRepo<T>
    {
        Task<List<T>> Listar();
        Task<string> Insertar(T objInsertar, int idCliente);
        Task<string> Eliminar(int id);
        Task<string> Actualizar(T objActualizar, string numFacAnt, int idCliente);
        Factura ObtenerIdUltimaFactura();
        Task<Factura> ObtenerFacturaPorId(int id);
    }
}
