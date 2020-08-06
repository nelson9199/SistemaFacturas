using Sistema.Datos.FacturaRepository;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio.FacturaLogic
{
    public class NFactura : IFacturaAccesRepo<Factura>
    {
        private readonly IFacturaRepository<Factura> facturaRepository;

        public NFactura(IFacturaRepository<Factura> facturaRepository)
        {
            this.facturaRepository = facturaRepository;
        }

        public async Task<string> Actualizar(Factura objActualizar, string numFacAnt, int idCliente)
        {
            if (numFacAnt.Equals(objActualizar.NumeroFactura))
            {
                return await facturaRepository.Actualizar(objActualizar);
            }
            else
            {
                bool existeCodigoFac = await facturaRepository.ExisteNumeroFactura(objActualizar.NumeroFactura, idCliente);

                if (existeCodigoFac == true)
                {
                    return "Ya existe una factura con el mismo número de factura";
                }
                return await facturaRepository.Actualizar(objActualizar);
            }
        }

        public async Task<string> Eliminar(int id)
        {
            return await facturaRepository.Eliminar(id);
        }

        public async Task<string> Insertar(Factura objInsertar, int idClietne)
        {
            bool existeCodigoFac = await facturaRepository.ExisteNumeroFactura(objInsertar.NumeroFactura, idClietne);

            if (existeCodigoFac == true)
            {
                return "Ya existe una factura con el mismo número de factura";
            }
            return await facturaRepository.Insertar(objInsertar);
        }

        public async Task<List<Factura>> Listar()
        {
            return await facturaRepository.Listar();
        }

        public async Task<Factura> ObtenerFacturaPorId(int id)
        {
            return await facturaRepository.ObtenerFacturaPorId(id);
        }

        public Factura ObtenerIdUltimaFactura()
        {
            return facturaRepository.ObtenerIdUltimaFactura();
        }
    }
}
