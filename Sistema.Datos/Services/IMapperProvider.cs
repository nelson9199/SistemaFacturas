using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Datos.Services
{
    public interface IMapperProvider
    {
        IMapper GetMapper();
    }
}
