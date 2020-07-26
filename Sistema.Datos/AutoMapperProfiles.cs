using AutoMapper;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Datos
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Cliente, Cliente>()
                .ForMember(x => x.ClienteFacturas, memberOptions: x => x.Ignore())
                .ForMember(x => x.EstaBorrado, memberOptions: x => x.Ignore())
                .ForMember(x => x.Estado, memberOptions: x => x.Ignore());

            CreateMap<Factura, Factura>()
                .ForMember(x => x.ClienteFacturas, memberOptions: x => x.Ignore());
        }
    }
}
